namespace Cs958 {
    public class Exercicio {
        public static int funcaoRetornaQuantitadePOV(decimal porcentagem, int totalNegociado) =>
            (int)Math.Truncate((porcentagem * totalNegociado) / (1 - porcentagem));
    }
}