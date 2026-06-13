using Estacionamento.Repositories ;

VeiculoRepository repo = new VeiculoRepository();

Console.WriteLine("PLACA:");
string placa = Console.ReadLine()?? "" ;

Console.WriteLine("MODELO:");
string modelo = Console.ReadLine() ?? "";

Console.WriteLine("COR:");
string cor = Console.ReadLine() ?? "";

Console.WriteLine("TIPO:");
string tipo = Console.ReadLine() ?? "";

repo  .Inserir(
    placa,
    modelo,
    cor,
    tipo
);

Console.WriteLine("Veiculo cadastrado!");
Console.ReadKey();
