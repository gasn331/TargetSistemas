namespace TesteTargetSistemas.NUnitTests
{
    public class FaturamentoDistribuidoraTests
    {
        private FaturamentoDistribuidora _distribuidora;

        [SetUp]
        public void SetUp()
        {
            decimal[] faturamento = { 1000m, 2000m, 3000m, 4000m, 500m };
            _distribuidora = new FaturamentoDistribuidora(faturamento);
        }

        [Test]
        public void ObterMenorFaturamento_DeveRetornarMenorValor()
        {
            // Act
            var menorFaturamento = _distribuidora.ObterMenorFaturamento();

            // Assert
            Assert.AreEqual(500m, menorFaturamento);
        }

        [Test]
        public void ObterMaiorFaturamento_DeveRetornarMaiorValor()
        {
            // Act
            var maiorFaturamento = _distribuidora.ObterMaiorFaturamento();

            // Assert
            Assert.AreEqual(4000m, maiorFaturamento);
        }

        [Test]
        public void ObterMediaFaturamento_DeveRetornarMediaCorreta()
        {
            // Act
            var mediaFaturamento = _distribuidora.ObterMediaFaturamento();

            // Assert
            Assert.AreEqual(2100m, mediaFaturamento);
        }

        [Test]
        public void ObterDiasAcimaDaMedia_DeveRetornarNumeroCorretoDeDias()
        {
            // Act
            var diasAcimaDaMedia = _distribuidora.ObterDiasAcimaDaMedia();

            // Assert
            Assert.AreEqual(2, diasAcimaDaMedia);
        }

        [Test]
        public void ObterMenorFaturamento_DeveLancarExcecao_QuandoNaoHouverFaturamento()
        {
            // Arrange
            var distribuidoraVazia = new FaturamentoDistribuidora(new decimal[0]);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => distribuidoraVazia.ObterMenorFaturamento());
        }
    }
}
