const form = document.getElementById("form");
const nomeInput = document.getElementById("nome");
const emailInput = document.getElementById("email");
const lista = document.getElementById("lista");
const errorDiv = document.getElementById("error");

const inscritos = [];

form.addEventListener("submit", (e) => {
  e.preventDefault();
  errorDiv.textContent = "";

  const nome = nomeInput.value.trim();
  const email = emailInput.value.trim();

  // Validação de campos vazios //
  if (!nome || !email) {
    errorDiv.textContent = "⚠️ Preencha todos os campos!";
    return;
  }

  // Validação do nome - apenas letras, maiúsculas e minúsculas //
  const nomeRegex = /^[A-Za-zÀ-ÖØ-öø-ÿ\s]+$/;

  if (!nomeRegex.test(nome)) {
    errorDiv.textContent =
      "⚠️ O nome deve conter apenas letras, sem números ou símbolos !";
    return;
  }

  if (!email.includes("@")) {
    errorDiv.textContent = "⚠️ Insira um e-mail válido!";
    return;
  }

  // Verificação de email existente //
  const emailExiste = inscritos.some((pessoa) => pessoa.email === email);
  if (emailExiste) {
    errorDiv.textContent = "⚠️ Este e-mail já foi cadastrado!";
    return;
  }

  inscritos.push({ nome, email });

  // Atualizar lista na tela //
  renderLista();

  // Limpar os campos //
  nomeInput.value = "";
  emailInput.value = "";
});

function renderLista() {
  lista.innerHTML = "";
  inscritos.forEach((pessoa) => {
    const li = document.createElement("li");
    li.textContent = `${pessoa.nome} - ${pessoa.email}`;
    lista.appendChild(li);
  });
}
