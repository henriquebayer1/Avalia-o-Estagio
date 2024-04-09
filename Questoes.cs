        //questão 1
        
Console.WriteLine("Digite a idade em anos, meses e dias:");

        Console.Write("Anos: ");
        int anos = int.Parse(Console.ReadLine());

        Console.Write("Meses: ");
        int meses = int.Parse(Console.ReadLine());

        Console.Write("Dias: ");
        int dias = int.Parse(Console.ReadLine());

        int idadeEmDias = anos * 365 + meses * 30 + dias;

        Console.WriteLine($"A idade em dias é: {idadeEmDias} dias.");


        //questão 2
        
        Console.WriteLine("Informe a quantidade de carros vendidos:");
        int numCarrosVendidos = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe o valor total das vendas realizadas pelo vendedor:");
        double valorTotalVendas = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe o salário fixo do vendedor:");
        double salarioFixo = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe o valor da comissão por carro vendido:");
        double comissaoPorCarro = double.Parse(Console.ReadLine());

        double comissaoTotal = numCarrosVendidos * comissaoPorCarro;

        double salarioFinal = salarioFixo + comissaoTotal + (valorTotalVendas * 0.05);

        Console.WriteLine($"O valor do salário total feito pelo vendedor é de: {salarioFinal:C}");

        //Questao 3 SQL 

//         SELECT 
        //     P.NOME_PROD AS "Nome do Produto",
        //     (P.PRC_PROD + COALESCE(SUM(C.PRC_COR), 0)) AS "Preço do Produto (com cores)",
        //     (P.PRC_PROD * 1.1) AS "Preço do Produto com acréscimo de 10%",
        //     (P.PRC_PROD * 0.9) AS "Preço do Produto com desconto de 10%",
        //     COALESCE(C.NOME_COR, 'Sem cor') AS "Cor do Produto"
        // FROM 
        //     PRODUTOS AS P
        // LEFT JOIN 
        //     CORES AS C
        // ON P.IDPRODUTO = C.IDPRODUTO
        // GROUP BY 
        //     P.IDPRODUTO, P.NOME_PROD, P.PRC_PROD, C.NOME_COR;

