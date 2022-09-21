//---------------------------------------------------------------------------------
// <copyright file="AllInOnePrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------
using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
   public class ConsolePrinter:IPrintMode
   {
    public void Print(Recipe recipe)
    {
        Console.WriteLine(recipe.GetTextToPrint());
    }
   }
}