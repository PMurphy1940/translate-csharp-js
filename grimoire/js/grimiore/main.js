function main() {
  // Put your code here
  const allSpells = [
    {
      name: "Turn enemy into a newt",
      IsEvil: true,
      EnergyRequired: 5.1,
    },
    {
      name: "Conjure some gold for a local charity",
      IsEvil: false,
      EnergyRequired: 2.99,
    },
    {
      name: "Give a deaf person the ability to heal",
      IsEvil: false,
      EnergyRequired: 12.2,
    },
    {
      name: "Make yourself emperor of the universe",
      IsEvil: true,
      EnergyRequired: 100,
    },
    {
      name: "Convince your relatives your political views are correct",
      IsEvil: false,
      EnergyRequired: 2921.5,
    },
  ];

  const SpellBook = {
    makeEvilSpellBook() {
      let evilSpells = allSpells.filter((spell) => {
        if (spell.IsEvil) {
          return spell;
        }
      });
      return evilSpells;
    },
    makeGoodSpellBook() {
      let goodSpells = allSpells.filter((spell) => {
        if (!spell.IsEvil) {
          return spell;
        }
      });
      return goodSpells;
    },
  };
  let evilSpells = SpellBook.makeEvilSpellBook();
  let goodSpells = SpellBook.makeGoodSpellBook();

  let goodbook = {
    title: "Good Book",
    spells: goodSpells,
  };

  let evilBook = {
    title: "Evil Book",
    spells: evilSpells,
  };

  console.log("Do you believe in magic?");
  console.log("------------------------");
  console.log(goodbook.title);
  goodbook.spells.forEach((spell) => {
    console.log(spell.name);
  });
  console.log("");
  console.log(evilBook.title);
  evilBook.spells.forEach((spell) => {
    console.log(spell.name);
  });
}

main();
