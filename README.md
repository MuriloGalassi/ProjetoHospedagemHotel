# Sistema de Hospedagem de Hotel

Este é um sistema simples de hospedagem de hotel desenvolvido em **C#** utilizando os conceitos de **Programação Orientada a Objetos (POO)**. O programa permite gerenciar hóspedes, suítes e reservas, incluindo o cálculo de valores de diárias com descontos baseados na duração da estadia.

## Funcionalidades

- Cadastro de hóspedes com nome e documento.
- Gerenciamento de suítes com tipo, capacidade e valor da diária.
- Criação de reservas associando hóspedes e suítes.
- Cálculo do valor total da diária, com desconto de **10%** para reservas de **10 dias ou mais**.
- Representação textual clara de hóspedes, suítes e reservas.

## Estrutura do Projeto

O projeto é dividido em três classes principais:

### Classe `Pessoa`
Representa os hóspedes do sistema.
- **Propriedades**:
  - `Nome`: Nome do hóspede.
  - `Documento`: Documento de identificação.
- **Métodos**:
  - `ToString()`: Retorna uma descrição textual do hóspede.

### Classe `Suite`
Representa as suítes disponíveis no hotel.
- **Propriedades**:
  - `TipoSuite`: Tipo da suíte (ex.: Luxo, Standard).
  - `Capacidade`: Capacidade máxima de hóspedes.
  - `ValorDiaria`: Valor da diária em reais.
- **Métodos**:
  - `ToString()`: Retorna uma descrição textual da suíte.

### Classe `Reserva`
Gerencia a relação entre hóspedes e suítes.
- **Propriedades**:
  - `Hospedes`: Lista de hóspedes cadastrados na reserva.
  - `SuiteReservada`: Suíte associada à reserva.
  - `DiasReservados`: Quantidade de dias reservados.
- **Métodos**:
  - `CadastrarHospede(Pessoa hospede)`: Adiciona um hóspede à reserva.
  - `CadastrarSuite(Suite suite)`: Associa uma suíte à reserva.
  - `ObterQuantidadeHospedes()`: Retorna a quantidade de hóspedes cadastrados.
  - `CalcularValorDiaria()`: Calcula o valor total da reserva, aplicando desconto se aplicável.
  - `ToString()`: Retorna uma descrição textual da reserva.

## Como Usar

1. Clone o repositório:
   ```bash
   https://github.com/MuriloGalassi/ProjetoHospedagemHotel.git
