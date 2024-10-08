# Government Service Project

This project was generated with [Angular CLI](https://github.com/angular/angular-cli) version 18.

## Table of Contents

1. [Requirements](#requirements)
2. [Installation](#installation)
3. [Usage](#usage)
    - [Start Development Server](#1-start-development-server)
    - [Build Project](#2-build-project)
    - [Run Linter Tests](#3-run-linter-tests)

---

## Requirements

To work with this project, ensure the following dependencies are installed:

- [nvm (Node Version Manager)](https://github.com/nvm-sh/nvm)
- [Node.js](https://nodejs.org/en) (version 18)
- [Yarn](https://classic.yarnpkg.com/en/)

---

## Installation

### 1. Set up the correct Node.js version

#### If using `nvm`:

Run the following command to switch to the required Node.js version:

```bash
nvm use
```

#### If not using `nvm`:

Download and install [Node.js](https://nodejs.org/en) version 18 directly from the official site:

[Node.js Downloads](https://nodejs.org/en/download/package-manager)

---

### 2. Install Yarn

Once Node.js is installed, install Yarn globally using npm:

```bash
npm install --global yarn
```

---

### 3. Install Project Dependencies

Install the project dependencies using Yarn:

```bash
yarn
```
or

```bash
yarn install
```

---

## Usage

### 1. Start Development Server

To run the application in development mode, use one of the following commands:

```bash
yarn start
```
or

```bash
ng serve
```

The app will be available at `http://localhost:4200/`.

---

### 2. Build Project

To create a production-ready build of the project, run:

```bash
yarn build
```
or

```bash
ng build
```

The build artifacts will be stored in the `dist/` directory.

---

### 3. Run Linter Tests

To check the project for linting errors, use:

```bash
yarn lint
```

This will run the linter and display any issues with the code style or formatting.
