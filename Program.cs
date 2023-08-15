Console.WriteLine("Organize seu churras");
Console.WriteLine("Quantos adultos irão comparecer?");
double adultos;
adultos = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("Quantas crianças irão comparecer?");
double crianca;
crianca = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("Quantos adultos consomem bebidas alcoólicas?");
double alcool;
alcool = Convert.ToDouble(Console.ReadLine()!);
double carne;
carne = (adultos * 400) + crianca * 200;
double acompanhamento;
double carnetotal;
carnetotal = carne / 1000;
acompanhamento = (adultos * 200) + crianca * 200;
double acomptotal;
acomptotal = acompanhamento / 1000;
double agua;
agua = (adultos * 400) + crianca * 400;
double aguatotal;
aguatotal = agua / 1000;
double bebebrefri;
if (adultos < alcool){
    bebebrefri = alcool - adultos;
}
else{ 
    bebebrefri = adultos - alcool;
}
double refri;
refri = (bebebrefri *500) + crianca * 500;
double refritotal;
refritotal = refri / 1000;
double cerveja;
cerveja = alcool * 2000;
double cervejatotal;
cervejatotal = cerveja / 1000;
Console.WriteLine();
Console.WriteLine("----Churrasco----");
Console.WriteLine($"Adultos (que consomem bebidas alcoólicas).......: {alcool}");
Console.WriteLine($"Adultos (que não consomem bebidas alcoólicas)...: {bebebrefri}");
Console.WriteLine($"Crianças........................................: {crianca}");
Console.WriteLine();
Console.WriteLine($"Carne.............: {carnetotal}Kg");
Console.WriteLine($"Acompanhamentos...: {acomptotal}Kg");
Console.WriteLine($"Cerveja...........: {cervejatotal}L");
Console.WriteLine($"Refrigerante......: {refritotal}L");
Console.WriteLine($"Água..............: {aguatotal}L");