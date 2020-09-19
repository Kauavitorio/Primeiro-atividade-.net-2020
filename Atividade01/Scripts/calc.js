var valor;
function botao(num) {
    valor = document.calc.visor.value += num;
}
function reseta() {
    document.calc.visor.value = "";
}
var resultado
function calcula() {
    resultado = eval(valor);
    document.calc.visor.value = resultado;
}