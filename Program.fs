let calcularSaldo receita despesas =
    receita - despesas 

let saldo = calcularSaldo 3000m 850m

printfn "MeuBolso - Controle de despesas"
printfn "Saldo disponivel: R$ %.2f" saldo

