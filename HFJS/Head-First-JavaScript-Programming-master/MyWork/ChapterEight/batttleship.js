var view = {
	displayMessage: function(msg){
		var messageArea = document.getElementById("messageArea")
		messageArea.innerHTML = msg;
	}

	displayHit: function(location) {
		var cell = document.getElementById(location);
		cell.setAttribute("class", "hit");
	}

	displayMiss: function(location){
		var cell = document.getElementById(location);
		cell.setAttribute("class", "miss");
	}
}

var model = {
	boardSize:7,
	numShips:3,
	shipLength:3,
	shipsSunk:0,

	ships: [{locations: ["06", "16", "26"], hits: ["","",""]},
			{locations: ["24", "34", "44"], hits: ["","",""]},
			{locations: ["10", "11", "12"], hits: ["","",""]}
	],

	fire: function(guess) {
		for(var i=0; i<this.numShips; i++) {
			var ship = this.ships[i];
			locations = ship.locations;
			var index = locations.indexOf[guess];
			if (index>=0) {
				msg = "HIT";
				ship.hits[index] = "hit";
				this.displayMessage(msg);
				this.displayHit();
				return true
			}
		}
		return false;
	}

	isSunk: function(ship) {
		for (var i=0; i<this.numShips; i++) {
			var ship = this.ship[i];
			var index = ship.locations.
		}
	}
}