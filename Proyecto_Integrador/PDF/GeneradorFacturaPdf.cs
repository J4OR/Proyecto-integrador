using Proyecto_Integrador.Models;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.Reflection.Metadata;

namespace Proyecto_Integrador.PDF
{
    public class GeneradorFacturaPDF
    {
        private readonly Factura factura;

        public GeneradorFacturaPDF(Factura factura)
        {
            this.factura = factura;
            QuestPDF.Settings.License = LicenseType.Community;
        }

        public void Exportar(string rutaPdf)
        {
            QuestPDF.Fluent.Document.Create(doc =>
            {
                doc.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(50);
                    page.DefaultTextStyle(x => x.FontFamily("Arial").FontSize(9));

                    page.Content().Column(col =>
                    {
                        // Encabezado
                        col.Item().Row(row =>
                        {
                            row.RelativeItem().Column(c =>
                            {
                                c.Item().Text("MOVITERRA S.A.S.").Bold().FontSize(16);
                                c.Item().Text("NIT: 900.123.456-7");
                                c.Item().Text("Tel: (601) 555 1234");
                            });

                            row.ConstantItem(150).Column(c =>
                            {
                                c.Item().Text("FACTURA").Bold().FontSize(14).AlignRight();
                                c.Item().Text("No. " + factura.id).AlignRight();
                                c.Item().Text("Fecha: " + factura.fecha.ToString("dd/MM/yyyy")).AlignRight();
                            });
                        });

                        col.Item().PaddingVertical(6).LineHorizontal(1);

                        // cliente
                        col.Item().PaddingBottom(10).Column(c =>
                        {
                            c.Item().Text("cliente:  " + (factura.cotizacion?.cliente?.nombre ?? "—"));
                            c.Item().Text("NIT/CC:  " + (factura.cotizacion?.cliente?.identificacion ?? "—"));
                            c.Item().Text("Tel:        " + (factura.cotizacion?.cliente?.telefono ?? "—"));
                        });

                        // Tabla
                        col.Item().Table(tabla =>
                        {
                            tabla.ColumnsDefinition(cols =>
                            {
                                cols.RelativeColumn(4);  // Descripción
                                cols.ConstantColumn(50); // Unidad
                                cols.ConstantColumn(55); // Cantidad
                                cols.ConstantColumn(75); // V. Unitario
                                cols.ConstantColumn(75); // V. Total
                            });

                            // Cabecera
                            foreach (var h in new[] { "Descripción", "Unidad", "Cantidad", "V. Unitario", "V. Total" })
                            {
                                tabla.Header(header =>
                                    header.Cell().Background("#0F2850").Padding(5)
                                        .Text(h).Bold().FontColor(Colors.White).FontSize(8));
                            }

                            // Filas
                            int n = 1;
                            foreach (var item in factura.items)
                            {
                                string bg = n++ % 2 == 0 ? "#F0F4FF" : Colors.White;
                                tabla.Cell().Background(bg).Padding(4).Text(item.descripcion);
                                tabla.Cell().Background(bg).Padding(4).AlignCenter().Text(item.unidad);
                                tabla.Cell().Background(bg).Padding(4).AlignRight().Text(item.cantidad.ToString("N2"));
                                tabla.Cell().Background(bg).Padding(4).AlignRight().Text(item.valorUnitario.ToString("C0"));
                                tabla.Cell().Background(bg).Padding(4).AlignRight().Text(item.valorTotal.ToString("C0"));
                            }
                        });

                        col.Item().PaddingVertical(6).LineHorizontal(1);

                        // Totales
                        decimal sub = factura.subtotal;
                        decimal iva = sub * 0.19m;
                        decimal total = sub + iva;

                        col.Item().AlignRight().Column(c =>
                        {
                            c.Item().Text($"Subtotal:   {sub:C0}");
                            c.Item().Text($"IVA (19%): {iva:C0}");
                            c.Item().PaddingTop(4).Text($"TOTAL:      {total:C0}").Bold().FontSize(11);
                        });

                        // Observaciones
                        if (!string.IsNullOrEmpty(factura.observacion))
                        {
                            col.Item().PaddingTop(16).Column(c =>
                            {
                                c.Item().Text("Observaciones:").Bold();
                                c.Item().Text(factura.observacion);
                            });
                        }
                    });

                    // Pie
                    page.Footer().AlignCenter()
                        .Text("MOVITERRA S.A.S.  |  Expertos en movimiento de tierra")
                        .FontSize(7).FontColor(Colors.Grey.Medium);
                });
            })
            .GeneratePdf(rutaPdf);
        }
    }
}