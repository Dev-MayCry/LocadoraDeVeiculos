using LocadoraDeVeiculos.Dominio.ModuloAluguel;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Net.Mail;

namespace LocadoraDeVeiculos.Infra.Pdf {
    public class GeradorAluguelEmPdf : IGeradorArquivo {
        public GeradorAluguelEmPdf() {
        }

        public void GerarAluguel(Aluguel aluguel) {
            PdfDocument document = new();
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont fonte = new("Verdana", 16, XFontStyle.Regular);
            EscreverAluguel(document, page, gfx, fonte, aluguel);
            EnviarPorEmail(document, gfx, aluguel);
        }


        private void EscreverAluguel(PdfDocument document, PdfPage page, XGraphics gfx, XFont fonte, Aluguel aluguel) {
            gfx.DrawString($"Id: {aluguel.Id}", fonte, XBrushes.Black, new XRect(50, -200, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString($"Nome do Condutor: {aluguel.Condutor.Nome}", fonte, XBrushes.Black, new XRect(50, -180, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString($"Veículo: {aluguel.Automovel}", fonte, XBrushes.Black, new XRect(50, -160, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString($"Data de Saída: {aluguel.DataLocacao}", fonte, XBrushes.Black, new XRect(50, -140, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString($"Data Prevista: {aluguel.DataDevolucaoPrevista}", fonte, XBrushes.Black, new XRect(50, -120, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString($"Data de Devolução: {aluguel.DataDevolucao}", fonte, XBrushes.Black, new XRect(50, -100, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString($"Valor Total: {aluguel.ValorTotal}", fonte, XBrushes.Black, new XRect(50, -80, page.Width, page.Height), XStringFormats.CenterLeft);
        }

        private void EnviarPorEmail(PdfDocument document, XGraphics gfx, Aluguel aluguel) {
            // Salva o PDF em um MemoryStream
            MemoryStream pdfStream = new MemoryStream();
            document.Save(pdfStream, false);
            pdfStream.Position = 0; // Volta ao início do MemoryStream

            // Aqui você usaria o MemoryStream para anexar o PDF ao email
            EnviarEmailComAnexo(pdfStream, aluguel);

            // Fechar e liberar recursos
            gfx.Dispose();
            document.Close();
            pdfStream.Close();
        }

        static void EnviarEmailComAnexo(Stream anexoStream, Aluguel aluguel) {
            // Configuração do email (substitua pelos seus valores)
            string emailRemetente = "guilherme.gmdp@gmail.com";
            string emailDestinatario = aluguel.Cliente.Email;
            string assunto = "Documento de aluguel";
            string corpo = "Segue em anexo o documento de aluguel.";

            // Cria o email e adiciona o anexo
            using (MailMessage mensagem = new MailMessage(emailRemetente, emailDestinatario, assunto, corpo)) {
                // Adiciona o PDF como anexo
                Attachment anexo = new Attachment(anexoStream, "DocumentoAluguel.pdf", "application/pdf");
                mensagem.Attachments.Add(anexo);


                try {
                    // Configuração do servidor de email (substitua pelos seus valores)
                    SmtpClient clienteSmtp = new SmtpClient("smtp.gmail.com") {
                        Port = 587,
                        Credentials = new System.Net.NetworkCredential("guilherme.gmdp@gmail.com", "pyybudkxgcdvlbjn"),
                        EnableSsl = true
                    };

                    // Envia o email
                    clienteSmtp.Send(mensagem);

                }catch (Exception ex) {

                }
            }
        }
    }
}
