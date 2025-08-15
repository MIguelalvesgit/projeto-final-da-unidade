@import url('https://fonts.googleapis.com/css2?family=Montserrat:ital,wght@0,100..900;1,100..900&display=swap');
@import url('https://fonts.googleapis.com/css2?family=Lemon&display=swap');

:root {
  --laranja-claro: #FF862A;
  --alto-contraste-fundo: #000000;
  --alto-contraste-texto: #ffffff;
  --alto-contraste-link: #ffd700;
  --focus: #1e90ff;
}

* { box-sizing: border-box; }

body {
  font-size: 1rem;              /* Base controlada pelo JS */
  font-family: 'Montserrat', system-ui, -apple-system, Segoe UI, Roboto, sans-serif;
  line-height: 1.6;
  background-color: #ffffff;
  color: #222222;
}

/* Link de pulo para conteúdo */
.skip-link {
  position: absolute;
  left: -999px;
  top: 0;
  background: #000;
  color: #fff;
  padding: .5rem 1rem;
  z-index: 10000;
}
.skip-link:focus { left: 8px; top: 8px; border-radius: 6px; }

header { background-color: #ffffff; }

section { padding-bottom: 5rem; }

.nav-link { color: #CB6D43; font-weight: 600; }
.nav-link:focus-visible,
.nav-link:hover { text-decoration: underline; }

/* Hero */
.inicio-fundo {
  background-image: url('img/4965007.jpg'); /* substitua pela sua imagem */
  background-size: cover;
  background-position: right;
  border-radius: 80px;
  width: 100%;
  min-height: 606px;
  padding: 40px;
  margin: 0 auto;
  position: relative;
}

/* imagem à direita */
.img-inicio {
  position: absolute;
  right: 0;
  top: 18rem;
  width: 45rem;
  max-width: 95%;
  height: auto;
}

.esquerda-conteudo {
  display: flex;
  flex-direction: column;
  align-items: flex-start;
  gap: 1rem;
}

.botao-inicio {
  background-color: var(--laranja-claro);
  border-radius: 30px;
  border: none;
  width: 14em;
  height: 3em;
  align-content: center;
}

.display-4 { text-shadow: -5px 5px var(--laranja-claro); }

/* Seção texto/ornamentos */
#tropicalia {
  position: relative;
  padding-top: 5rem;
  margin-top: 3rem;
  margin-bottom: 3rem;
  background:
    url('img/flor.png') top right no-repeat,
    url('img/flor-esquerda.png') bottom left no-repeat;
  background-size: 180px 180px;
}

#tropicalia .container {
  display: flex;
  align-items: center;
  justify-content: center;
  position: relative;
  z-index: 1;
}

h2 {
  font-family: 'Lemon', serif;
  font-size: 2.5em;
  font-style: normal;
  color: var(--laranja-claro);
}

#galeria { background-color: #FAF4F4; }

.fundo-galeria {
  background: url('img/flor-bottom-direita.png') bottom right no-repeat;
  background-size: 180px 180px;
}

#contato {
  background-image: url('img/4965007.jpg');
  background-size: cover;
  padding: 4rem 0;
}

.formulario {
  background-color: #ffffff;
  padding: 2rem;
  border-radius: 10px;
  box-shadow: 0 0 10px rgba(0,0,0,.1);
  font-weight: bold;
}

.formulario button {
  background-color: #CB6D43;
  border: none;
  font-weight: bold;
}

.form-control { background-color: #F1EDEF; }

/* Acessibilidade: menu flutuante */
.menu-acessibilidade {
  position: fixed;
  top: 2rem;
  right: 20px;
  z-index: 1000;
}

.rotacao-botao {
  transform: rotate(-90deg);
  transform-origin: right center;
}

.opcoes-acessibilidade {
  margin-top: 10px;
  display: flex;
  flex-direction: column;
}

.opcoes-acessibilidade button { margin-bottom: 5px; }
.apresenta-lista { display: none; }

/* Alto contraste */
.alto-contraste {
  background-color: var(--alto-contraste-fundo);
  color: var(--alto-contraste-texto);
}

.alto-contraste header,
.alto-contraste footer,
.alto-contraste .formulario {
  background-color: var(--alto-contraste-fundo);
  color: var(--alto-contraste-texto);
}

.alto-contraste .nav-link { color: var(--alto-contraste-link); }

.alto-contraste .botao-inicio,
.alto-contraste .formulario button,
.alto-contraste .btn-primary {
  background-color: var(--alto-contraste-link);
  color: var(--alto-contraste-fundo);
  border: none;
}

.alto-contraste #tropicalia { background: none; }
.alto-contraste #galeria { background-color: var(--alto-contraste-fundo); }
.alto-contraste .fundo-galeria { background: none; }

/* Foco visível global */
:focus-visible {
  outline: 3px solid var(--focus);
  outline-offset: 3px;
  border-radius: 6px;
}

/* Animações reduzidas */
@media (prefers-reduced-motion: reduce) {
  * { animation: none !important; transition: none !important; scroll-behavior: auto !important; }
}
