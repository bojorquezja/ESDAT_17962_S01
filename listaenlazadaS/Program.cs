
using listaenlazadaS;

Locomotora l =  new Locomotora();
l.AgregaFinal(2);
l.AgregaFinal(10);
l.AgregaFinal(20);
Console.WriteLine(l.VerVagones());
Console.WriteLine();
l.EliminaUltimo();
Console.WriteLine(l.VerVagones());
if (l.ExisteValor(10)) {
    Console.WriteLine("Existe el 10");
} else {
    Console.WriteLine("No Existe");
}