// Verificando se Naruto ja é Hokage 

bool isHogake = true;

if (isHogake){
    Console.WriteLine("Naruto é Hokage");
     Console.WriteLine("----------------------------------");
} else {
    Console.WriteLine("Naruto não é Hokage");
    Console.WriteLine("----------------------------------");
}

int NarutoIdade = 25;

if (NarutoIdade < 10){
    Console.WriteLine("Naruto é uma criança, Esta na escola");
} else if (NarutoIdade >= 10 && NarutoIdade <18){
    Console.WriteLine("Naruto é um adolescente, Ja esta na academia ninja");
} else if (NarutoIdade >=18 && NarutoIdade < 30){
    Console.WriteLine("Naruto é um adulto e ja pode ser Hokage");
} else {
    Console.WriteLine("Naruto é um idoso e se aposentou");
}