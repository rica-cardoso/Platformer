# 🎮 Plataforma 2D - Jogo no estilo Mario Bros/Sonic

Bem-vindo ao **meu jogo de plataforma 2D**, desenvolvido na Unity 2022.3.50f1 como parte do curso ministrado por **Wenes Soares** na **CSJ Academy**. O jogo segue o estilo clássico de plataformas, inspirado em títulos como **Mario Bros** e **Sonic**, combinando várias mecânicas para proporcionar uma jogabilidade divertida e desafiadora! 🕹️🎉

## 🚀 Funcionalidades do Jogo

- **Movimentação fluida** com o uso do sistema de **Rigidbody2D** e controle de físicas 🏃‍♂️
- **Pulo duplo** (Double Jump) que permite alcançar novas plataformas e vencer obstáculos 🚀
- **Sistema de combate** ⚔️ com ataques precisos e colisões usando **OverlapCircle**
- **Animações** suaves com o **Animator** para transições entre correr, pular, atacar e muito mais 🎥
- **Inteligência Artificial dos inimigos** 👾, incluindo personagens como **Slime** e **Goblin**
- **Sistema de vida e recuperação** ❤️ que mantém o jogador em ação enquanto gerencia sua saúde
- **Game Over** quando a vida se esgota, trazendo um desafio adicional 💀
- **Interface de usuário (UI)** com placar de pontos, barra de vida e tela de fim de jogo 🖥️
- **Sistema de Checkpoint** para salvar o progresso e continuar de onde parou ✅
- **Coleta de moedas** 💰 com efeitos de som e animação para feedback instantâneo

## 🛠️ Tecnologias Utilizadas

- **Unity 2022.3.50f1** 🛠️
- **C#** para implementação de scripts e lógica de jogo 👨‍💻
- **TextMeshPro** para textos claros e de alta qualidade na UI 🔤
- **Coroutines** para controlar eventos como ataques e recuperação de vida ⏳
- **Physics2D** para garantir interações físicas e movimentos precisos ⚙️

## 📂 Estrutura do Projeto

```bash
/Assets
  /Scripts
    Player.cs  # Script de controle do jogador
    GameController.cs  # Gerenciamento de fases, checkpoints e Game Over
  /Prefabs
    Player.prefab  # Prefab do personagem principal
    Enemy.prefab  # Prefab dos inimigos
```

## 🕹️ Como Jogar
- **Movimentação**: Use as setas direcionais ou "A/D" para mover-se
- **Pulo**: Pressione barra de espaço para pular e, novamente, para pulo duplo
- **Atacar**: Use o botão esquerdo do mouse para atacar inimigos