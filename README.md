# Allhands Hotel — Conversor de Assets

Este repositório é a **ferramenta de baixar e converter assets oficiais** usada na montagem do catálogo do projeto **Allhands Hotel**. É um fork do [All-in-1 Converter](https://github.com/duckietm/all-in-1-converter), uma aplicação .NET multiplataforma que baixa mobílias, roupas, efeitos e badges direto do CDN oficial do Habbo, converte os arquivos SWF para o formato `.nitro` (usado pelo cliente HTML5) e gera os inserts SQL necessários para o catálogo.

## Sobre o projeto Allhands Hotel

O Allhands Hotel é composto por 5 repositórios que trabalham juntos:

| Repositório | Função |
|---|---|
| [`allhands-hotel-server`](https://github.com/Anuudek/allhands-hotel-server) | Servidor do jogo (Java / Polaris) |
| [`allhands-hotel-client`](https://github.com/Anuudek/allhands-hotel-client) | Cliente do jogo (React / Nitro) |
| [`allhands-hotel-renderer`](https://github.com/Anuudek/allhands-hotel-renderer) | Motor de renderização do jogo (PixiJS) |
| [`allhands-hotel-cms`](https://github.com/Anuudek/allhands-hotel-cms) | Site/CMS do hotel (Laravel / Atom CMS) |
| [`allhands-hotel-converter`](https://github.com/Anuudek/allhands-hotel-converter) *(este)* | Ferramenta que baixa e converte os assets oficiais do Habbo |

Diferente dos outros 4 repositórios, este **não roda como um serviço permanente** — é uma ferramenta de linha de comando usada pontualmente para popular o catálogo do servidor e do CMS com mobílias, roupas e efeitos oficiais.

## Stack

- **.NET 10** (C#)
- **FFDec** (Flash Decompiler) embutido, para extrair os arquivos SWF
- Três interfaces intercambiáveis: TUI (padrão), CLI e GUI (Avalonia)

## Modificações feitas para o Allhands Hotel

Este fork adiciona duas flags de linha de comando pensadas para automação (sem menus interativos):

```bash
dotnet "Habbo Downloader.dll" --auto-download-all   # baixa mobílias, roupas, efeitos e badges
dotnet "Habbo Downloader.dll" --auto-convert-all    # converte todo o SWF baixado para .nitro
```

Além disso, o `config.ini` já vem apontado para o domínio `.com.br` (em vez do `.nl` padrão), evitando textos e nomes em holandês no catálogo.

## Créditos

Baseado no excelente trabalho do time do [All-in-1 Converter](https://github.com/duckietm/all-in-1-converter). Este fork adiciona automação para rodar sem interação como parte do pipeline de deploy do Allhands Hotel.
