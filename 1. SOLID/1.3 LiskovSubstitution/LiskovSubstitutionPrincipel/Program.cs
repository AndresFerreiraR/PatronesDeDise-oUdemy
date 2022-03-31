// See https://aka.ms/new-console-template for more information

using LiskovSubstitutionPrincipel.Clases;
using LiskovSubstitutionPrincipel.Interfaces;

Animal animal = new Dog();
animal.Noise = "sss";
animal.MakeNoise();
//animal.Fly();


ICanFly bird = new Bird();
bird.Noise = "sss";
bird.MakeNoise();
bird.Fly();
