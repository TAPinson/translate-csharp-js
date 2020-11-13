function main() {
  // Put your code here

  const places = ["Nashville", "Hong Kong", "The back yard", "Earth",
    "London", "The mall", "Ryman Auditorium", "The Great Wall of China"]

  console.log("All Place Names")

  places.map((place) => {
    console.log(place)
  })

  const thePlaces = places.filter((place) => {
    return place.startsWith("The")
  })
  console.log("")
  console.log("'The' Place Names")
  thePlaces.map((place) => {
    console.log(place)
  })

}

main();