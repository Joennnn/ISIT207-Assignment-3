// Name: Joen Tai
// UOW ID: 7432100
// SIM ID: 10237942

//Task 3 Part (a)
var jsontext = '{ "extinctanimal": ' + 
    '{ "animal": [' +
        '{"Type": "Woolly Mammoth", "Rank": "One"},' +
        '{"Type": "Dodo", "Rank": "Two"},' +
        '{"Type": "Sabre-toothed Cat", "Rank": "Three"},' +
        '{"Type": "Great Auk", "Rank": "Four"},' +
        '{"Type": "Stellers Sea Cow", "Rank": "Five"}]' +
    '}}';

//Task 3 Part (b)
let statement = "";
let text = '{ "extinctanimal": ' + 
    '{ "animal": [' +
        '{"Type": "Woolly Mammoth", "Rank": "One"},' +
        '{"Type": "Dodo", "Rank": "Two"},' +
        '{"Type": "Sabre-toothed Cat", "Rank": "Three"},' +
        '{"Type": "Great Auk", "Rank": "Four"},' +
        '{"Type": "Stellers Sea Cow", "Rank": "Five"}]' +
    '}}';

const obj = JSON.parse(text);
function listFunction(){
    for (var i = 0, len = text.length; i < len; ++i) {
        var node = document.createElement("li");
        statement += obj.extinctanimal.animal[i].Type + 
                    " is ranked number " + 
                    obj.extinctanimal.animal[i].Rank;
        var textnode = document.createTextNode(statement);
    
        console.log(statement);
    
        statement = "";
        node.appendChild(textnode);
        document.getElementById("animals").appendChild(node);
    };
};
