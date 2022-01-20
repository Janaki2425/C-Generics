using System;

namespace Generics;

public class Program

{
    public static void Main(String[] args)
    {
        Maxnos maxnosUC1 = new Maxnos();
        maxnosUC1.Maximumvalue();
        MaxFloats maxfloatsUC2 = new MaxFloats();
        maxfloatsUC2.Maximumfloat();
        Maxstrings maxstringsUC3 = new Maxstrings();
        maxstringsUC3.Maximumstring();
        RefactorGenericMethod<T> refactorGenericMethod = new();
        refactorGenericMethod.Comparevalues();
        RefactorGenericClass<T> refactorGenericClass = new();
        refactorGenericClass.Comparevalue();
        refactorGenericClass.Maxmethod();



            


    }
    
}

internal class T
{
}