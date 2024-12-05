
# Turing Machine Project

## Overview
The **Turing Machine Project** showcases the design and implementation of a Turing Machine for performing unary operations. This project includes a detailed description of the machine's states, transitions, and configurations, as well as JSON files for simulating the Turing Machine using an online simulator.

The project focuses on demonstrating how a Turing Machine operates by modifying its state and tape configurations to achieve specific computational goals.

## Features
- **Graphical Representation**:
  - A graph illustrating the Turing Machine's states and transitions.
- **Formal Definition**:
  - States: {q0, q1, q2, q3, q4, q5, q6, q7, q8}
  - Start State: {q0}
  - Symbols: {1, /\}
  - Action Table: Defined within the documentation.
- **Machine Description**:
  - Detailed explanation of the Turing Machine's functionality and logic.
  - Explanation of changes made to optimize or modify its behaviour.
- **JSON Configurations**:
  - **TM4.json** and **TM7.json** files to simulate the Turing Machine on [Turing Machine Simulator](https://math.hws.edu/eck/js/turing-machine/TM.html).

## Contents
- `TuringMachines.pdf`: A comprehensive document containing:
  - Graph and formal definition of the Turing Machine.
  - Description of the machine's states, logic, and behaviour.
  - Configurations and computation paths for various inputs.
  - Changes to the graph and their implications.
- **JSON Files**:
  - `TM4.json`: An earlier configuration of the Turing Machine.
  - `TM7.json`: A modified configuration representing the updated graph and logic.

## Usage
1. **Viewing the Documentation**:
   - Open `TuringMachines.pdf` to explore the design and functionality of the Turing Machine.
2. **Simulating the Turing Machine**:
   - Visit [Turing Machine Simulator](https://math.hws.edu/eck/js/turing-machine/TM.html).
   - Load either `TM4.json` or `TM7.json` into the simulator.
   - Run the simulation to observe the machine's behaviour and computations for different inputs.

## How It Works
- The Turing Machine starts at state `q0` and processes an input tape consisting of unary symbols (1) separated by spaces or blank symbols (/).
- It transitions through various states (`q0` to `q8`) based on the current symbol and pointer location, performing operations such as marking, looping, and outputting results.
- For every input of `1`, the machine generates a specific output, with configurations detailed in the provided documentation.

## Key Changes
- A minimal adjustment was made to the original graph:
  - Changed the action between `q0` and `q7` to transform the function from `(n, 3n)` to `4n + 1`, effectively altering the machine's output pattern.

## File Descriptions
- `TuringMachines.pdf`: Full project documentation, including the formal definition, graph, and configurations.
- `TM4.json`: JSON file representing the initial Turing Machine configuration.
- `TM7.json`: JSON file reflecting the updated graph and state transitions.

---

Feel free to explore, simulate, and analyze the Turing Machine! If you have questions or feedback, please reach out.
