const { Console } = require("console");
const fs = require("fs");

let content = fs.readFileSync("C:/Users/BB/.bbconfig", { encoding: "utf8" });
console.log(JSON.parse(content.toString()));

/*
fs.readFile("C:/Users/BB/.bbconfig", function (err, data) {
    console.log(data);
    console.log(err);
    if (data)
    {
        console.log("Read JSON file: " + data);
        data = data.trim(); 
        let storage = JSON.parse(data);
        console.log(storage);
    }

});
*/

