Console.WriteLine();
int qtAdultosBebem, qtAdultosNaoBebem, criancas; 
double carne, acompanhamento, cerveja, refrigerante, agua;

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("---------CHURRASCARIA COMEBEM---------");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Adultos que tomam bebidas alcoólicas : ");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Red;
qtAdultosBebem = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Adultos que não tomam bebidas alcoólicas : ");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Red;
qtAdultosNaoBebem = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Crianças : ");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Red;
criancas = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();


int TodosAdultos = qtAdultosBebem + qtAdultosNaoBebem;
carne = 0.4 * TodosAdultos + 0.2 * criancas;

int TodoMundo = TodosAdultos + criancas;
acompanhamento = 0.2 * TodoMundo;

cerveja = 2 * qtAdultosBebem;

int puros = qtAdultosNaoBebem + criancas;
refrigerante = 0.5 * puros;

agua = 0.4 * TodoMundo;

Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("-----RESULTADO-----");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"carnes : {carne:N1} kg");
Console.WriteLine($"acompanhamentos : {acompanhamento:N1} kg");
Console.WriteLine($"cervejas : {cerveja:N1} L");
Console.WriteLine($"Refrigerantes : {refrigerante:N1} L");
Console.WriteLine($"águas : {agua:N1} L");
Console.ResetColor();



 