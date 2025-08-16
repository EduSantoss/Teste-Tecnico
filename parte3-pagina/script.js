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

  // Validação //
  if (!nome || !email) {
    errorDiv.textContent = "⚠️ Preencha todos os campos!";
    return;
  }

  if (!email.includes("@")) {
    errorDiv.textContent = "⚠️ Insira um e-mail válido!";
    return;
  }

  inscritos.push({ nome, email });

  // Atualizar lista na tela
  renderLista();

  // Limpar os campos
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
