let calcularSaldo receita despesas =
    receita - List.sum despesas

let saldo = calcularSaldo 3000m [850m; 200m; 150m]

printfn "MeuBolso - Controle de despesas"
printfn "Saldo disponivel: R$ %.2f" saldo

