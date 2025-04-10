
using listaenlazadaS;

Locomotora l =  new Locomotora();
l.AgregaFinal(20);
l.AgregaFinal(10);
l.AgregaFinal(2);
Console.WriteLine(l.VerVagones());
Console.WriteLine();
l.EliminaUltimo();
Console.WriteLine(l.VerVagones());
if (l.ExisteValor(10)) {
    Console.WriteLine("Existe el 10");
} else {
    Console.WriteLine("No Existe");
}
Console.WriteLine(l.Largo());
Console.WriteLine(l.GetValor(1));

Locomotora m = new Locomotora();
m.AgregaFinal(90);
m.AgregaFinal(80);
l.AgregaLEFinal(m);
Console.WriteLine(l.VerVagones());

l.Ordena();
Console.WriteLine(l.VerVagones());