using System;  


class minhaClasse { 


  static void Main(string[] args) {  


    double salario = 0.00; 
    double reajuste = 0.00; 
    double novoSalario = 0.00; 
    double percentual = 0.00; 
  
    salario = Convert.ToDouble(Console.ReadLine()); 
   
    if( salario < 0.0 ) { 
      return; 

    } else if ( salario >= 0.0 && salario <= 400.00 ) { 
      percentual = 15.0/100.00; 
      reajuste = salario * percentual; 
      novoSalario = reajuste + salario; 

    } else if ( salario > 400.00  && salario <= 800.00) { 
      percentual = 12.0/100.00; 
      reajuste = salario * percentual;         
      novoSalario = reajuste + salario; 

    } else if ( salario > 800.00  && salario <= 1200.00) { 
      percentual = 10.0/100.00; 
      reajuste = salario * percentual; 
      novoSalario = reajuste + salario; 

    } else if (salario > 1200.00  && salario <= 2000.00) { 
      percentual = 7.0/100.00; 
      reajuste =  salario * percentual; 
      novoSalario =  reajuste + salario; 

    } else { 
      percentual = 4.0/100.00; 
      reajuste = salario * percentual ; 
      novoSalario =reajuste + salario  ; 
    } 
    Console.WriteLine("Novo salario: {0:0.00}",  novoSalario); 
    Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste); 
    Console.WriteLine("Em percentual: {0} %", percentual*100.00); 
  } 
}