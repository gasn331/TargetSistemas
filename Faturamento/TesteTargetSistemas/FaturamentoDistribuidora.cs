using System;

namespace TesteTargetSistemas
{
    public class FaturamentoDistribuidora
    {
        private readonly decimal[] _faturamento;

        public FaturamentoDistribuidora(decimal[] faturamento)
        {
            _faturamento = faturamento ?? throw new ArgumentNullException(nameof(faturamento));
        }

        public decimal ObterMenorFaturamento()
        {
            if (_faturamento.Length == 0)
                throw new InvalidOperationException("O vetor não pode estar vazio.");

            decimal menor = _faturamento[0];

            foreach (var valor in _faturamento)
            {
                if (valor < menor) menor = valor;
            }

            return menor;
        }

        public decimal ObterMaiorFaturamento()
        {
            if (_faturamento.Length == 0)
                throw new InvalidOperationException("O vetor não pode estar vazio.");

            decimal maior = _faturamento[0];

            foreach (var valor in _faturamento)
            {
                if (valor > maior) maior = valor;
            }

            return maior;
        }

        public decimal ObterMediaFaturamento()
        {
            if (_faturamento.Length == 0)
                throw new InvalidOperationException("O vetor não pode estar vazio.");

            decimal soma = 0;

            foreach (var valor in _faturamento)
            {
                soma += valor;
            }

            return soma / _faturamento.Length;
        }

        public int ObterDiasAcimaDaMedia()
        {
            decimal media = ObterMediaFaturamento();
            int diasAcimaDaMedia = 0;

            foreach (var valor in _faturamento)
            {
                if (valor > media) diasAcimaDaMedia++;
            }

            return diasAcimaDaMedia;
        }
    }
}
