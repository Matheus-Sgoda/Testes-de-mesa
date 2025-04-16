public class CalculadoraJuros
{
    
    public static List<ResultadoMensal> CalcularRendimento(
        double valorInicial, double taxaMensal, int meses, int dias, 
        int retiradaMes = 0, decimal retiradaValor = 0)
    {
        List<ResultadoMensal> resultados = new List<ResultadoMensal>();
        DateTime dataAtual = DateTime.Today;
        double taxaAnual = taxaMensal * 12;
        double taxaDiaria = 1 + (taxaAnual / 100) / 365;
        double valorAtual = valorInicial;
        
       // Adiciona o resultado inicial (mês 0)'
        resultados.Add(new ResultadoMensal
        {
            Mes = 0,
            Data = dataAtual,
            ValorAnterior = valorInicial,
            JurosNoPeriodo = 0,
            ValorAcumulado = valorInicial,
            Retirada = 0
        });
        
        // Calcula para cada mês
        for (int mes = 1; mes <= meses; mes++)
        {
            DateTime dataAnterior = dataAtual;
            dataAtual = dataAtual.AddMonths(1);
            int diasNoPeriodo = (dataAtual - dataAnterior).Days;
            
            double valorAnterior = valorAtual;
            valorAtual = valorAtual * Math.Pow(taxaDiaria, diasNoPeriodo);
            double jurosNoPeriodo = valorAtual - valorAnterior;
            
            decimal valorRetirada = 0;
            
            // Aplica a retirada se for o mês correto
            if (mes == retiradaMes)
            {
                valorRetirada = retiradaValor;
                valorAtual -= (double)retiradaValor;
                if (valorAtual < 0) valorAtual = 0;
            }
            
            resultados.Add(new ResultadoMensal
            {
                Mes = mes,
                Data = dataAtual,
                ValorAnterior = valorAnterior,
                JurosNoPeriodo = jurosNoPeriodo,
                ValorAcumulado = valorAtual,
                Retirada = valorRetirada
            });
        }
        
        // Aplica os dias adicionais se houver
        if (dias > 0)
        {
            double valorAnterior = valorAtual;
            valorAtual *= Math.Pow(taxaDiaria, dias);
            double jurosDias = valorAtual - valorAnterior;
            DateTime dataFinal = dataAtual.AddDays(dias);
            
            resultados.Add(new ResultadoMensal
            {
                Mes = meses + 1,
                Data = dataFinal,
                ValorAnterior = valorAnterior,
                JurosNoPeriodo = jurosDias,
                ValorAcumulado = valorAtual,
                Retirada = 0
            });
        }
        
        return resultados;
    }
}


public class ResultadoMensal
{
    public int Mes { get; set; }
    public DateTime Data { get; set; }
    public double ValorAnterior { get; set; }
    public double JurosNoPeriodo { get; set; }
    public double ValorAcumulado { get; set; }
    public decimal Retirada { get; set; }
}