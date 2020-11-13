function main() {

  const allSpells = [
    {
      Name: "Turn enemy into a newt",
      IsEvil: true,
      EnergyReqired: 5.1
    },
    {
      Name: "Conjure some gold for a local charity",
      IsEvil: false,
      EnergyReqired: 2.99
    },
    {
      Name: "Give a deaf person the ability to heal",
      IsEvil: false,
      EnergyReqired: 12.2
    },
    {
      Name: "Make yourself emperor of the universe",
      IsEvil: true,
      EnergyReqired: 100.0
    },
    {
      Name: "Convince your relatives your political views are correct",
      IsEvil: false,
      EnergyReqired: 2921.5
    }
  ]


  const goodSpells = allSpells.filter((spell) => {
    return spell.IsEvil === false
  })

  const evilSpells = allSpells.filter((spell) => {
    return spell.IsEvil === true
  })

  const goodBook = {
    title: "Good Book",
    spells: goodSpells
  }

  const evilBook = {
    title: "Evil Book",
    spells: evilSpells
  }

  console.log("Do you believe in magic?");
  console.log("------------------------");
  console.log(goodBook.title)
  goodBook.spells.map((spell) => {
    console.log(spell.Name)
  })
  console.log(" ")
  console.log(evilBook.title)
  evilBook.spells.map((spell) => {
    console.log(spell.Name)
  })


}

main();