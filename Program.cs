// Definição das variáveis para o cálculo do consumo da churrascaria
int qtAdultosBebem, qtAdultosNaoBebem, criancas;
double carne, acompanhamento, cerveja, refrigerante, agua;

// Define a cor do texto do console como ciano e exibe a mensagem "---------CHURRASCARIA COMEBEM---------"
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("---------CHURRASCARIA COMEBEM---------");
Console.ResetColor();

// Define a cor do texto do console como amarelo e exibe a mensagem "Adultos que tomam bebidas alcoólicas : "
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Adultos que tomam bebidas alcoólicas : ");
Console.ResetColor();

// Define a cor do texto do console como vermelho, solicita uma entrada do usuário e armazena a quantidade de adultos que bebem
qtAdultosBebem = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();

// Define a cor do texto do console como amarelo e exibe a mensagem "Adultos que não tomam bebidas alcoólicas : "
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Adultos que não tomam bebidas alcoólicas : ");
Console.ResetColor();

// Define a cor do texto do console como vermelho, solicita uma entrada do usuário e armazena a quantidade de adultos que não bebem
qtAdultosNaoBebem = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();

// Define a cor do texto do console como amarelo e exibe a mensagem "Crianças : "
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Crianças : ");
Console.ResetColor();

// Define a cor do texto do console como vermelho, solicita uma entrada do usuário e armazena a quantidade de crianças
criancas = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();

// Calcula a quantidade de todos os adultos
int TodosAdultos = qtAdultosBebem + qtAdultosNaoBebem;

// Calcula a quantidade de carne necessária
carne = 0.4 * TodosAdultos + 0.2 * criancas;

// Calcula a quantidade de acompanhamento necessário
int TodoMundo = TodosAdultos + criancas;
acompanhamento = 0.2 * TodoMundo;

// Calcula a quantidade de cerveja necessária
cerveja = 2 * qtAdultosBebem;

// Calcula a quantidade de refrigerante necessário
int puros = qtAdultosNaoBebem + criancas;
refrigerante = 0.5 * puros;

// Calcula a quantidade de água necessária
agua = 0.4 * TodoMundo;

// Imprime uma linha vazia no console
Console.WriteLine();

// Define a cor do texto do console como verde e exibe a mensagem "-----RESULTADO-----"
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("-----RESULTADO-----");
Console.ResetColor();

// Define a cor do texto do console como verde escuro e exibe as quantidades necessárias de carne, acompanhamento, cerveja, refrigerante e água
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"carnes : {carne:N1} kg");
Console.WriteLine($"acompanhamentos : {acompanhamento:N1} kg");
Console.WriteLine($"cervejas : {cerveja:N1} L");
Console.WriteLine($"Refrigerantes : {refrigerante:N1} L");
Console.WriteLine($"águas : {agua:N1} L");
Console.ResetColor();