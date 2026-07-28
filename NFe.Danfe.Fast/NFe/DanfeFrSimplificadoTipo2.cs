using DFe.Utils;
using NFe.Classes;
using NFe.Danfe.Base.NFCe;
using NFe.Danfe.Base.NFe;
using Shared.DFe.Danfe;

namespace NFe.Danfe.Fast.NFe
{
    public class DanfeFrSimplificadoTipo2 : DanfeFastBase
    {
        /// <summary>
        /// Construtor da classe responsável pela impressão do DANFE Simplificado Tipo 2 da NFe em Fast Reports
        /// </summary>
        /// <param name="proc">Objeto do tipo nfeProc</param>
        /// <param name="configuracaoDanfeNfe">Objeto do tipo <see cref="ConfiguracaoDanfeNfe"/> contendo as definições de impressão</param>
        /// <param name="desenvolvedor">Texto do desenvolvedor a ser informado no DANFE</param>
        /// <param name="arquivoRelatorio">Caminho do arquivo frx</param>
        public DanfeFrSimplificadoTipo2(nfeProc proc, ConfiguracaoDanfeNfce configuracaoDanfeNfce, ConfiguracaoDanfeNfe configuracaoDanfeNfe, string cIdToken, string csc, string desenvolvedor = "", string arquivoRelatorio = "")
        {
            byte[] frx = null;
            if (string.IsNullOrWhiteSpace(arquivoRelatorio))
            {
                const string caminho = @"NFe\NFeSimplificadoTipo2.frx";
                frx = FrxFileHelper.TryGetFrxFile(caminho);
            }

            Relatorio = DanfeSharedHelper.GenerateDanfeFrNfeReport(proc, configuracaoDanfeNfce, configuracaoDanfeNfe, cIdToken, csc, frx, desenvolvedor, arquivoRelatorio);
        }
    }
}