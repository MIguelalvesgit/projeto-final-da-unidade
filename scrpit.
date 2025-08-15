document.addEventListener('DOMContentLoaded', () => {
  const botaoDeAcessibilidade = document.getElementById('botao-acessibilidade');
  const opcoesDeAcessibilidade = document.getElementById('opcoes-acessibilidade');
  const aumentaFonteBotao = document.getElementById('aumentar-fonte');
  const diminuiFonteBotao = document.getElementById('diminuir-fonte');
  const alternaContraste = document.getElementById('alterna-contraste');
  const statusForm = document.getElementById('status-form');

  // ===== Persistência de preferências =====
  const CONTRASTE_KEY = 'pref_alto_contraste';
  const FONTE_KEY = 'pref_tamanho_fonte';

  function aplicarPreferencias() {
    const contrasteAtivo = localStorage.getItem(CONTRASTE_KEY) === 'true';
    const tamanhoSalvo = parseFloat(localStorage.getItem(FONTE_KEY));

    document.body.classList.toggle('alto-contraste', contrasteAtivo);
    alternaContraste.setAttribute('aria-pressed', String(contrasteAtivo));

    if (!isNaN(tamanhoSalvo)) {
      document.body.style.fontSize = `${tamanhoSalvo}rem`;
    }
  }

  aplicarPreferencias();

  // ===== Menu de acessibilidade =====
  botaoDeAcessibilidade.addEventListener('click', () => {
    botaoDeAcessibilidade.classList.toggle('rotacao-botao');
    opcoesDeAcessibilidade.classList.toggle('apresenta-lista');

    const expandido = botaoDeAcessibilidade.getAttribute('aria-expanded') === 'true';
    botaoDeAcessibilidade.setAttribute('aria-expanded', String(!expandido));
  });

  // Aumentar/Diminuir fonte com limites e persistência
  function getTamanhoAtual() {
    const current = parseFloat(getComputedStyle(document.body).fontSize) / 16; // rem
    return parseFloat(current.toFixed(2));
  }

  function setTamanhoFonte(rem) {
    const novo = Math.max(0.8, Math.min(1.8, rem)); // limites entre 0.8rem e 1.8rem
    document.body.style.fontSize = `${novo}rem`;
    localStorage.setItem(FONTE_KEY, String(novo));
  }

  aumentaFonteBotao.addEventListener('click', () => setTamanhoFonte(getTamanhoAtual() + 0.1));
  diminuiFonteBotao.addEventListener('click', () => setTamanhoFonte(getTamanhoAtual() - 0.1));

  // Alternar alto contraste com persistência
  alternaContraste.addEventListener('click', () => {
    const ativo = !document.body.classList.contains('alto-contraste');
    document.body.classList.toggle('alto-contraste', ativo);
    alternaContraste.setAttribute('aria-pressed', String(ativo));
    localStorage.setItem(CONTRASTE_KEY, String(ativo));
  });

  // ===== Formulário: validação simples e mensagem acessível =====
  const form = document.querySelector('form');
  form.addEventListener('submit', (e) => {
    e.preventDefault();
    const nome = document.getElementById('nome');
    const email = document.getElementById('email');
    const mensagem = document.getElementById('mensagem');

    if (nome.value.trim() && email.validity.valid && mensagem.value.trim()) {
      statusForm.classList.remove('visually-hidden');
      statusForm.textContent = 'Mensagem enviada! Obrigado pelo contato.';
      form.reset();
    } else {
      statusForm.classList.remove('visually-hidden');
      statusForm.textContent = 'Por favor, preencha todos os campos corretamente.';
    }
  });

  // ===== ScrollReveal: respeitar prefers-reduced-motion =====
  const reduzMovimento = window.matchMedia('(prefers-reduced-motion: reduce)').matches;

  if (typeof ScrollReveal !== 'undefined' && !reduzMovimento) {
    ScrollReveal().reveal('#inicio', { delay: 200, distance: '20px', origin: 'bottom' });
    ScrollReveal().reveal('#tropicalia', { delay: 200, distance: '20px', origin: 'bottom' });
    ScrollReveal().reveal('#galeria', { delay: 200, distance: '20px', origin: 'bottom' });
    ScrollReveal().reveal('#contato', { delay: 200, distance: '20px', origin: 'bottom' });
  }
});
