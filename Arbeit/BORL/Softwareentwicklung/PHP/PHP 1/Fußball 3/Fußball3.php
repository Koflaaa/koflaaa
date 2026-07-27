<?php
    class Team {
        public $name;
        public $age;

        public function __construct($name = "", $age = 0) {
            $this->name = $name;
            $this->age = $age;
        }
    }

    class FieldPlayer extends Team {
        public $skillStrength;
        public $shootingQuality;
        public $motivation;
        public $number;

        public function __construct($skillStrength = 0, $shootingQuality = 0, $motivation = 0, $number = 0) {
            $this->skillStrength = $skillStrength;
            $this->shootingQuality = $shootingQuality;
            $this->motivation = $motivation;
            $this->number = $number;
        }

        public function introduce() {
            echo "Name: {$this->name}<br>";
            echo "Age: {$this->age}<br>";
            echo "Shooting Quality: {$this->shootingQuality}<br>";
            echo "Number: {$this->number}<br><br>";
        }

        public function generateRandomName() {
            $names = ["Thomas", "Dennis", "August", "Nicolaus", "Volkhard", "Ferdi", "Michel", "Helmut", "Bjoern", "Mathias"];
            $lastNames = ["Sylvester", "Bertram", "Diethelm", "Ferdinand", "Hans-Günter", "Hendrik", "Dietrich", "Bruno", "Gert", "Eike"];
            $randomFirstNameIndex = rand(0, count($names) - 1);
            $randomLastNameIndex = rand(0, count($lastNames) - 1);
            $this->name = "{$names[$randomFirstNameIndex]} {$lastNames[$randomLastNameIndex]}";
        }
    }

    class Goalie extends Team {
        public $reactionCapacity;
        public $skillStrength;
        public $motivation;

        public function __construct($reactionCapacity = 0, $skillStrength = 0, $motivation = 0) {
            $this->reactionCapacity = $reactionCapacity;
            $this->skillStrength = $skillStrength;
            $this->motivation = $motivation;
        }

        public function introduce() {
            echo "Name: {$this->name}<br>";
            echo "Age: {$this->age}<br>";
            echo "Skill Strength: {$this->skillStrength}<br>";
            echo "Reaction Capacity: {$this->reactionCapacity}<br><br>";
        }

        public function generateRandomName() {
            $names = ["Thomas", "Dennis", "August", "Nicolaus", "Volkhard", "Ferdi", "Michel", "Helmut", "Bjoern", "Mathias"];
            $lastNames = ["Sylvester", "Bertram", "Diethelm", "Ferdinand", "Hans-Günter", "Hendrik", "Dietrich", "Bruno", "Gert", "Eike"];
            $randomFirstNameIndex = rand(0, count($names) - 1);
            $randomLastNameIndex = rand(0, count($lastNames) - 1);
            $this->name = "{$names[$randomFirstNameIndex]} {$lastNames[$randomLastNameIndex]}";
        }
    }

    // Function to display team information
    function displayTeam($teamName, $goalie, $fieldPlayers) {
        echo "<h2>$teamName</h2>";
        echo "<h3>Goalie</h3>";
        $goalie->generateRandomName();
        $goalie->introduce();

        echo "<h3>Field Players</h3>";
        foreach ($fieldPlayers as $player) {
            $player->generateRandomName();
            $player->introduce();
        }
    }

    // Initialize teams and players
    $goalie1 = new Goalie(rand(1, 10), rand(1, 10), rand(1, 10));
    $fieldPlayers1 = [];
    for ($i = 0; $i < 10; $i++) {
        $fieldPlayers1[] = new FieldPlayer(rand(1, 10), rand(1, 10), rand(1, 10), $i + 1);
    }

    $goalie2 = new Goalie(rand(1, 10), rand(1, 10), rand(1, 10));
    $fieldPlayers2 = [];
    for ($i = 0; $i < 10; $i++) {
        $fieldPlayers2[] = new FieldPlayer(rand(1, 10), rand(1, 10), rand(1, 10), $i + 1);
    }
    ?>

    <div>
        <?php
        // Display initial team information
        displayTeam("Team1", $goalie1, $fieldPlayers1);
        echo "<br>";
        displayTeam("Team2", $goalie2, $fieldPlayers2);
        ?>
    </div>

    <br><br>

    <form method="post" action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]);?>">
        <label for="team">Choose your team to shoot:</label>
        <select name="team" id="team">
            <option value="Team">Team</option>
            <option value="Team2">Team2</option>
        </select><br><br>
        <label for="player">Choose your player (1-10):</label>
        <input type="number" id="player" name="player" min="1" max="10" required><br><br>
        <input type="submit" value="Submit">
    </form>

    <?php
    // Process form submission
    if ($_SERVER["REQUEST_METHOD"] == "POST") {
        $teamChoice = $_POST["team"];
        $playerChoice = $_POST["player"];
        $variance = rand(-2, 1);

        // Determine which team and player were chosen
        if ($teamChoice == "Team") {
            $selectedPlayer = $fieldPlayers1[$playerChoice - 1];
            $goalieStrength = $goalie2->reactionCapacity + $variance;
        } else {
            $selectedPlayer = $fieldPlayers2[$playerChoice - 1];
            $goalieStrength = $goalie1->reactionCapacity + $variance;
        }

        // Calculate shooting strength and determine winner
        $shootingStrength = $selectedPlayer->shootingQuality + $variance;

        echo "<h3>Selected Player:</h3>";
        $selectedPlayer->introduce();
        echo "Shooting quality of player {$selectedPlayer->number}: {$shootingStrength}<br>";
        echo "Goalie strength: {$goalieStrength}<br>";

        if ($shootingStrength > $goalieStrength) {
            echo "<h3>{$teamChoice} has won!</h3>";
        } else {
            echo "<h3>The other team has won!</h3>";
        }
    }
    ?>