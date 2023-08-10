using LocadoraDeVeiculos.Dominio.ModuloAluguel;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Net.Mail;
using System.Runtime.ConstrainedExecution;

namespace LocadoraDeVeiculos.Infra.Pdf {
    public class GeradorAluguelEmPdf : IGeradorArquivo {
        public GeradorAluguelEmPdf() {
        }

        public void GerarAluguel(Aluguel aluguel, bool encerrado) {
            PdfDocument document = new();
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont fonte = new("Verdana", 12, XFontStyle.Regular);
            XFont fonteTitulo = new("Verdana", 24, XFontStyle.Regular);
            XFont fonteIntroducao = new("Verdana", 10, XFontStyle.Regular);
            if (encerrado) EscreverAluguelEncerrado(document, page, gfx, fonte, aluguel, fonteTitulo, fonteIntroducao);
            else EscreverAluguelAberto(document, page, gfx, fonte, aluguel, fonteTitulo, fonteIntroducao);
            EnviarPorEmail(document, gfx, aluguel);
        }

        private void EscreverAluguelAberto(PdfDocument document, PdfPage page, XGraphics gfx, XFont fonte, Aluguel aluguel, XFont fonteTitulo, XFont fonteIntroducao) {
            gfx.DrawString("Locadora de Veículos Top", fonteTitulo, XBrushes.Black, new XRect(0, -380, page.Width, page.Height), XStringFormats.Center);
           
            gfx.DrawString($"Olá, {aluguel.Cliente.Nome}! Obrigado por escolher a Locadora de Veículos Top sua opção preferida", fonteIntroducao, XBrushes.Black, new XRect(20, -340, page.Width, page.Height), XStringFormats.Center);
            gfx.DrawString("para aluguel de veículos. Estamos empolgados por fazer parte da sua jornada.", fonteIntroducao, XBrushes.Black, new XRect(20, -320, page.Width, page.Height), XStringFormats.Center);
           

            gfx.DrawString("Detalhes do Aluguel:", fonte, XBrushes.Black, new XRect(0, -270, page.Width, page.Height), XStringFormats.Center);
            

            gfx.DrawString($"Id do Aluguel: {aluguel.Id}", fonte, XBrushes.Black, new XRect(50, -220, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString($"Nome do Condutor: {aluguel.Condutor.Nome}", fonte, XBrushes.Black, new XRect(50, -200, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString($"Veículo: {aluguel.Automovel}", fonte, XBrushes.Black, new XRect(50, -180, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString($"Data de Saída: {aluguel.DataLocacao.ToShortDateString()}", fonte, XBrushes.Black, new XRect(50, -160, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString($"Data Prevista: {aluguel.DataDevolucaoPrevista.ToShortDateString()}", fonte, XBrushes.Black, new XRect(50, -140, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString($"Valor Total: R$ {aluguel.ValorTotal}", fonte, XBrushes.Black, new XRect(50, -120, page.Width, page.Height), XStringFormats.CenterLeft);


            gfx.DrawString("Estamos comprometidos em tornar sua experiência excepcional e sem complicações. " ,fonteIntroducao, XBrushes.Black, new XRect(20, -40, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString("Nossa seleção de itens de aluguel foi cuidadosamente projetada para garantir sua comodidade. " ,fonteIntroducao, XBrushes.Black, new XRect(20, -20, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString("Desde opções flexíveis de cobrança até recursos personalizados," ,fonteIntroducao, XBrushes.Black, new XRect(20, 0, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString("estamos aqui para garantir que você tenha uma jornada memorável e conveniente.." ,fonteIntroducao, XBrushes.Black, new XRect(20, 20, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString("Fique à vontade para nos contatar a qualquer momento caso precise de assistência durante sua viagem", fonteIntroducao, XBrushes.Black, new XRect(20, 60, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString("Explore nossa ampla oferta e comece sua aventura com confiança.", fonteIntroducao, XBrushes.Black, new XRect(20, 80, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString("Bem-vindo à sua viagem perfeita!", fonteIntroducao, XBrushes.Black, new XRect(20, 100, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString("Atenciosamente,", fonteIntroducao, XBrushes.Black, new XRect(20, 130, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString("Equipe da Locadora de Veículos Top", fonteIntroducao, XBrushes.Black, new XRect(20, 140, page.Width, page.Height), XStringFormats.CenterLeft);

        }

        private void EscreverAluguelEncerrado(PdfDocument document, PdfPage page, XGraphics gfx, XFont fonte, Aluguel aluguel,XFont fonteTitulo, XFont fonteIntroducao) {
            gfx.DrawString("Locadora de Veículos Top", fonteTitulo, XBrushes.Black, new XRect(0, -380, page.Width, page.Height), XStringFormats.Center);

            gfx.DrawString($"Olá, {aluguel.Cliente.Nome}!", fonteIntroducao, XBrushes.Black, new XRect(20, -340, page.Width, page.Height), XStringFormats.Center);
            gfx.DrawString("Esperamos que sua jornada com a Locadora de Veículos Top tenha sido excelente.", fonteIntroducao, XBrushes.Black, new XRect(20, -320, page.Width, page.Height), XStringFormats.Center);
            gfx.DrawString("Agradecemos por escolher nossos serviços para atender às suas necessidades de mobilidade.", fonteIntroducao, XBrushes.Black, new XRect(20, -300, page.Width, page.Height), XStringFormats.Center);


            gfx.DrawString("Detalhes do Aluguel Encerrado:", fonte, XBrushes.Black, new XRect(0, -270, page.Width, page.Height), XStringFormats.Center);


            gfx.DrawString($"Id do Aluguel: {aluguel.Id}", fonte, XBrushes.Black, new XRect(50, -220, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString($"Nome do Condutor: {aluguel.Condutor.Nome}", fonte, XBrushes.Black, new XRect(50, -200, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString($"Veículo: {aluguel.Automovel}", fonte, XBrushes.Black, new XRect(50, -180, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString($"Data de Saída: {aluguel.DataLocacao.ToShortDateString()}", fonte, XBrushes.Black, new XRect(50, -160, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString($"Data de Devolução Realizada: {aluguel.DataDevolucao.ToShortDateString()}", fonte, XBrushes.Black, new XRect(50, -140, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString($"Valor Total: R$ {aluguel.ValorTotal}", fonte, XBrushes.Black, new XRect(50, -120, page.Width, page.Height), XStringFormats.CenterLeft);


            gfx.DrawString("Esperamos que tenha desfrutado de sua viagem e que tenha encontrado nosso serviço confiável e conveniente. ", fonteIntroducao, XBrushes.Black, new XRect(20, -40, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString("Sua satisfação é nossa prioridade e estamos sempre aqui para ajudar. ", fonteIntroducao, XBrushes.Black, new XRect(20, -20, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString("Caso tenha alguma dúvidaapós o encerramento do aluguel, não hesite em nos contatar.", fonteIntroducao, XBrushes.Black, new XRect(20, 0, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString("Agradecemos novamente por sua confiança e esperamos atendê-lo novamente no futuro.", fonteIntroducao, XBrushes.Black, new XRect(20, 20, page.Width, page.Height), XStringFormats.CenterLeft);
          
            gfx.DrawString("Atenciosamente,", fonteIntroducao, XBrushes.Black, new XRect(20, 130, page.Width, page.Height), XStringFormats.CenterLeft);
            gfx.DrawString("Equipe da Locadora de Veículos Top", fonteIntroducao, XBrushes.Black, new XRect(20, 140, page.Width, page.Height), XStringFormats.CenterLeft);
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
