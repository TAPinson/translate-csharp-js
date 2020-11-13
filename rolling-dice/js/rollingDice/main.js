function main() {
  // Put your code here
  const die = [
    {
      value: 1,
      dieString: "\u2680"
    },
    {
      value: 2,
      dieString: "\u2681"
    },
    {
      value: 3,
      dieString: "\u2682"
    },
    {
      value: 4,
      dieString: "\u2683"
    },
    {
      value: 5,
      dieString: "\u2684"
    },
    {
      value: 6,
      dieString: "\u2685"
    }
  ]

  function getRandomInt(min, max) {
    min = Math.ceil(1);
    max = Math.floor(6);
    return Math.floor(Math.random() * (max - min + 1)) + min;
  }

  const roll = () => {
    let rollOne = getRandomInt()
    let rollOneDie = rollOne - 1
    let rollOneFinal = die[rollOneDie].dieString
    let rollTwo = getRandomInt()
    let rollTwoDie = rollTwo - 1
    let rollTwoFinal = die[rollTwoDie].dieString
    if (rollOne === rollTwo) {
      return rollOneFinal + " + " + rollTwoFinal + " === " + (rollOne + rollTwo + " DOUBLES!")
    }
    return rollOneFinal + " + " + rollTwoFinal + " === " + (rollOne + rollTwo)
  }
  console.log("Let's roll some dice, baby!");
  console.log("---------------------------");
  console.log(roll())
  console.log(roll())
  console.log(roll())
  console.log(roll())
  console.log(roll())
  console.log(roll())
  console.log(roll())
  console.log(roll())
  console.log(roll())
  console.log(roll())
}

main();