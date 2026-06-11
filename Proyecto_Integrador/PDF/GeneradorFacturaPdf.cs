using System.Windows.Forms;
using Proyecto_Integrador.Models;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using Document = QuestPDF.Fluent.Document;

namespace Proyecto_Integrador.Utils
{
    public class GeneradorFacturaPDF
    {
        private readonly Factura factura;
        private readonly DataGridView grid;
        private static readonly string ruta = "C:\\Users\\jorte\\OneDrive\\Documentos\\Pdfs_Proyecto";

        public GeneradorFacturaPDF(Factura factura, DataGridView grid)
        {
            this.factura = factura ?? throw new System.ArgumentNullException(nameof(factura));
            this.grid = grid ?? throw new System.ArgumentNullException(nameof(grid));
            QuestPDF.Settings.License = LicenseType.Community;
        }

        public void Exportar(string rutaPdf)
        {
            // Validaciones tempranas para identificar la causa raíz y evitar NullReferenceException
            if (factura == null)
                throw new System.InvalidOperationException("La propiedad 'factura' es null. Inicialice GeneradorFacturaPDF con una instancia válida.");

            // Preparar valores seguros que se usarán dentro de los lambdas
            var idText = factura.id?.ToString() ?? "";
            var fechaText = factura.fecha.ToString("d/MM/yyyy");
            var cliente = factura.cotizacion?.cliente;
            var observacion = factura.observacion ?? "";
            double subtotal = factura.subtotal;
            double iva = factura.precioIva;
            double total = factura.total;

            Document.Create(documento =>
            {
                documento.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(40);
                    page.DefaultTextStyle(x => x.FontFamily("Arial").FontSize(9));

                    page.Content().Column(col =>
                    {
                        // ── Encabezado ─────────────────────────────────
                        col.Item().Background("#0F2850").Padding(12).Row(row =>
                        {
                            row.RelativeItem()
                                .Text("Sistema de Gestion de Movimiento de Tierra")
                                .Bold().FontSize(15).FontColor(Colors.White);

                            row.ConstantItem(180).Border(1).BorderColor(Colors.White)
                                .Padding(8).Column(c =>
                                {
                                    c.Item().Text("Numero Factura").Bold().FontColor(Colors.White);
                                    c.Item().Height(4);
                                    c.Item().Row(r =>
                                    {
                                        r.ConstantItem(25).Text("N°:").FontColor(Colors.White);
                                        r.RelativeItem().Background(Colors.White)
                                            .Padding(2).Text(idText);
                                    });
                                    c.Item().Height(4);
                                    c.Item().Row(r =>
                                    {
                                        r.ConstantItem(35).Text("Fecha:").FontColor(Colors.White);
                                        r.RelativeItem().Background(Colors.White)
                                            .Padding(2).Text(fechaText);
                                    });
                                });
                        });

                        col.Item().Height(10);

                        // ── Datos del cliente ──────────────────────────
                        col.Item().Border(1).BorderColor("#AABBDD").Column(c =>
                        {
                            c.Item().Background("#E8EEF8").Padding(5)
                                .Text("Datos del cliente").Bold().FontColor("#0F2850");

                            c.Item().Padding(8).Grid(grid =>
                            {
                                grid.Columns(12);

                                grid.Item(2).Text("Cliente:").Bold();
                                grid.Item(4).Text(cliente?.nombre ?? "");
                                grid.Item(2).Text("NIT / CC:").Bold();
                                grid.Item(4).Text(cliente?.identificacion ?? "");

                                grid.Item(2).Text("Correo:").Bold();
                                grid.Item(4).Text(cliente?.correo ?? "");
                                grid.Item(2).Text("Teléfono:").Bold();
                                grid.Item(4).Text(cliente?.telefono ?? "");
                            });
                        });

                        col.Item().Height(8);

                        // ── Tabla de ítems ─────────────────────────────
                        col.Item().Table(tabla =>
                        {
                            tabla.ColumnsDefinition(cols =>
                            {
                                cols.ConstantColumn(25);
                                cols.RelativeColumn(4);
                                cols.RelativeColumn(2);
                                cols.RelativeColumn(2);
                                cols.RelativeColumn(1.5f);
                                cols.RelativeColumn(2);
                            });

                            tabla.Header(header =>
                            {
                                foreach (var h in new[] { "", "Descripcion del servicio",
                                    "Precio Unitario", "Material", "Volumen", "Total" })
                                {
                                    header.Cell().Background("#0F2850").Padding(5)
                                        .Text(h).Bold().FontColor(Colors.White).FontSize(8);
                                }
                            });

                            // Si 'grid' es null, se omiten las filas (no lanzar excepción)
                            if (grid != null)
                            {
                                int n = 1;
                                foreach (DataGridViewRow row in grid.Rows)
                                {
                                    if (row.IsNewRow) continue;
                                    string bg = n % 2 == 0 ? "#F0F4FF" : Colors.White;

                                    tabla.Cell().Background(bg).Padding(4).AlignCenter().Text(n.ToString());
                                    tabla.Cell().Background(bg).Padding(4).Text(row.Cells["Descripcion"].Value?.ToString() ?? "");
                                    tabla.Cell().Background(bg).Padding(4).AlignRight().Text(row.Cells["PrecioUnitario"].Value?.ToString() ?? "");
                                    tabla.Cell().Background(bg).Padding(4).Text(row.Cells["Material"].Value?.ToString() ?? "");
                                    tabla.Cell().Background(bg).Padding(4).AlignRight().Text(row.Cells["Volumen"].Value?.ToString() ?? "");
                                    tabla.Cell().Background(bg).Padding(4).AlignRight().Text(row.Cells["Total"].Value?.ToString() ?? "");
                                    n++;
                                }
                            }
                        });

                        col.Item().Height(10);

                        // ── Observaciones + Totales ────────────────────
                        col.Item().Row(row =>
                        {
                            row.RelativeItem().Column(c =>
                            {
                                c.Item().Text("Observaciones").Bold();
                                c.Item().Height(4);
                                c.Item().Border(1).BorderColor("#AABBDD")
                                    .MinHeight(60).Padding(6)
                                    .Text(observacion);
                            });

                            row.ConstantItem(20);

                            // Totales directo desde la factura

                            row.ConstantItem(200).Column(c =>
                            {
                                c.Item().Row(r =>
                                {
                                    r.RelativeItem().Text("Subtotal:");
                                    r.ConstantItem(80).AlignRight().Text(subtotal.ToString("C0"));
                                });
                                c.Item().Height(4);
                                c.Item().Row(r =>
                                {
                                    r.RelativeItem().Text("Iva (19%):");
                                    r.ConstantItem(80).AlignRight().Text(iva.ToString("C0"));
                                });
                                c.Item().Height(6);
                                c.Item().Row(r =>
                                {
                                    r.RelativeItem().Text("Total:").Bold().FontSize(11);
                                    r.ConstantItem(80).AlignRight()
                                        .Text(total.ToString("C0")).Bold().FontSize(11);
                                });
                            });
                        });
                    });
                });
            })
            .GeneratePdf(ruta);
        }
    }
}