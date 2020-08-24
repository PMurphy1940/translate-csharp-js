function main() {
  // Put your code here
  const roll = () => {
    return Math.floor(Math.random() * 6 + 1);
  };
  console.log("Let's roll some dice, baby!");
  console.log("---------------------------");

  for (let i = 0; i < 10; i++) {
    let die1 = roll();
    let die2 = roll();
    let message = `${die1} + ${die2} === ${die1 + die2}`;
    if (die1 === die2) {
      message += " DOUBLES!";
    }
    console.log(message);
  }
}

main();