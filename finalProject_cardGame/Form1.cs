// 2023-04-10 / Yeonhee Do / 2211198 / Made Players group box
// 2023-04-22 / Yeonhee Do / 2211198 / Show ranking(in progress)
// 2023-04-24 / Yeonhee Do / 2211198 / Magics, Test
// 2023-04-25 / Yeonhee Do / 2211198 / Write comments, Final test

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace finalProject_cardGame
{
    public partial class Form1 : Form
    {
        // current image index of image list [Avatars]
        byte imgIndex = 0;
        // number of players for one game
        byte numberOfPlayers = 0;
        // maximum HP set
        byte maxHP = 0;
        // This will be true when a certain magic storm is occured.
        bool criticalDamage = false;

        // 2 Players who's currently playing the game
        Player currentP1 = null;
        Player currentP2 = null;

        // My game engine will be used globally
        GameEngine myGameEngine = null;

        public Form1()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // When user checks/unchecks [Saved players] radio button: 
        private void rbtnSavedPlayers_CheckedChanged(object sender, EventArgs e)
        {
            try
            {   // If radio button [Saved players]'s checked,
                // and if [Favorite players] panel was active, 
                if (pnlFavoritePlayers.Enabled)
                {
                    //[Favorite players] panel becomes inactive
                    pnlFavoritePlayers.Enabled = false;
                }
                else
                {   // If [Favorite players] panel was not active, it becomes active
                    pnlFavoritePlayers.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }          
        }

        // When user checks/unchecks [New players] radio button: 
        private void rbtnNewPlayers_CheckedChanged(object sender, EventArgs e)
        {
            try
            {   // If radio button [New players]'s checked,
                // and if [Create players] panel was active,
                if (pnlCreatePlayers.Enabled)
                {   // [Create players] panel becomes inactive
                    pnlCreatePlayers.Enabled = false;
                }
                else
                {   // If [Favorite players] panel was not active, it becomes active
                    pnlCreatePlayers.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // When user click [Create Players] button: 
        private void btnCreatePlayer_Click(object sender, EventArgs e)
        {
            try
            {   // If user didn't choose number of players
                if (cboxNumberOfPlayers.SelectedIndex == -1)
                {   // Game cannot start
                    MessageBox.Show("You must select a number of player.");
                }
                else
                {
                    // Apply game setting
                    GameSet();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // When user click [Use favorite players] button: 
        private void btnUseFavPlayer_Click(object sender, EventArgs e)
        {
            try
            {
                // Set the game before to start
                GameSet();

                // Bring saved favorite players list from the binary file
                myGameEngine.DeserializePlayers();

                // Put the favorite players into the player queue
                foreach (Player player in myGameEngine.players)
                {
                    // Put the player in the player queue
                    myGameEngine.playerQueue.Enqueue(player);
                }

                // Start new round of game
                StartRound();
                // Shuffle cards and refresh card decks
                myGameEngine.ShuffleCards();
                // Refresh and show remaining cards visually
                RefreshVisualRemainingCards();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Set a game before to start 
        private void GameSet()
        {
            try
            {
                // If user checked [Use joker] check box, make 54 cards
                // and if not, make 52 cards with a new game engine
                myGameEngine = new GameEngine(chbUseJoker.Checked);

                // Remove previous players list
                myGameEngine.players.Clear();
                // Remove previous players queue
                myGameEngine.playerQueue.Clear();

                // Get max HP value that user set and save it to maxHP variable
                maxHP = (byte)nudMaxHP.Value;
                // Set players' HP bars' maximum value
                pgbPlayer1HP.Maximum = maxHP;
                pgbPlayer2HP.Maximum = maxHP;

                // Get desired number of players from the combo box
                numberOfPlayers = Convert.ToByte(cboxNumberOfPlayers.SelectedItem);
                // Give players list spaces to contain players with the desired number
                myGameEngine.players = new List<Player>(numberOfPlayers);

                // Reset a group box [Round]
                ResetGrbRound();
                // Reset a group box [Players]
                ResetGrbPlayers();
                // Now user can access to [Players] group box
                EnableGrbPlayers();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Enable [Players] group box so user can add new players 
        private void EnableGrbPlayers()
        {
            try
            {
                // User can access to group box [Players]
                grbPlayers.Enabled = true;
                // User can type name of a new player
                txtbNameOfPlayer.Enabled = true;
                // User can choose avatar
                pbAvatars.Enabled = true;
                // User can add new players
                btnAddPlayer.Enabled = true;
                // User can save the players as favorite players
                chbSaveAsFavPlayers.Enabled = true;

                // Other group boxes are inactive now
                // Disabled [Game settings] group box
                grbGameSettings.Enabled = false;
                // Disabled [Round] group box
                grbRound.Enabled = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }          
        }

        // When an user click the [Add player] button: 
        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            try
            {   // Check if the player name is appropriate
                if (CheckPlayerName(txtbNameOfPlayer.Text))
                {   // If it's appropriate, create a new player with the name and current image index
                    CreateNewPlayer(txtbNameOfPlayer.Text, imgIndex);

                    // When players are all created, the game automatically starts
                    if (myGameEngine.playerQueue.Count == numberOfPlayers)
                    {
                        // If user wants to save current players list as favorite players
                        if (chbSaveAsFavPlayers.Checked)
                        {   // Save the list in a binary file
                            myGameEngine.SerializePlayers();
                        }
                        // Start a round. If there's no more than 2 players in the queue, game ends
                        StartRound();
                    }
                }

                // Modify label [Name of player] based on player's index
                lblNameOfPlayer.Text = "Name of player " + (myGameEngine.players.Count + 1) + ":";
                // Clear the player name input box
                txtbNameOfPlayer.Text = "";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Check if a new player name is appropriate 
        private bool CheckPlayerName(string newName)
        {
            try
            {
                // Check if the name is empty
                if (newName.Trim() == "")
                {   // If it's empty, user cannot use this name
                    MessageBox.Show("Player name cannot be empty.");
                    return false;
                }
                else
                {   // If the name is not empty,
                    // Check if the name is longer than 25 letters
                    if (newName.Length > 25)
                    {   // If it's longer than 25, user cannot use this name
                        MessageBox.Show("Player name cannot be longer than 25 letters.");
                        return false;
                    }
                    else
                    {   // If the name is not longer than 25 letters,
                        // Check if there is another player who use the same name
                        if (myGameEngine.players.Count == 0)
                        {   // If there is no players inside the list yet, user can use the name
                            return true;
                        }
                        else
                        {   // If there are more than one player in the list,
                            // Check every players' names in the list
                            foreach (Player player in myGameEngine.players)
                            {   // If there is a player who has the same name with the new name,
                                if (player.playerName == newName)
                                {   // User cannot use the name
                                    MessageBox.Show("Player name cannot be same with other players.");
                                    return false;
                                }
                                // If there is no player who has the same name,
                                else
                                {   // User can use the name as a new name
                                    return true;
                                }
                            }
                        }
                    }
                }
                // This is preventing a compiling error
                // ex) If the new name cannot be trimmed...
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Create a new player with new name and current image index, and put it in a list and a queue 
        private void CreateNewPlayer(string newName, byte newImgIndex)
        {
            try
            {   // Create new player
                Player newPlayer = new Player(newName, newImgIndex);
                // Set player's HP to max HP
                newPlayer.playerHP = maxHP;

                // Add the new player in the players list
                myGameEngine.players.Add(newPlayer);
                // Add the new player in the players queue
                myGameEngine.playerQueue.Enqueue(newPlayer);

                // Refresh the list view to show new players on it
                RefreshListView();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Start new round of game 
        private void StartRound()
        {
            try
            {
                // If there are more than 2 players in the player queue, game can be started
                if (myGameEngine.playerQueue.Count >= 2)
                {
                    // Round number is increased by 1
                    myGameEngine.roundNumber++;

                    // Refresh list view to show current player queue
                    RefreshListView();

                    // Shuffle cards and put them into a draw pile. Players' decks will be reset
                    myGameEngine.ShuffleCards();
                    // Refresh and show remaining cards visually
                    RefreshVisualRemainingCards();

                    // User can play a game
                    EnableGrbRound();

                    // Show the round number
                    grbRound.Text = "Round " + myGameEngine.roundNumber;

                    // Set 2 players for a round
                    SetPlayersForRound();

                    // Now it's all ready to start the round
                    MessageBox.Show("Let's start!");
                }
                else
                {   // If there are less than 2 players in the queue,
                    // Game is over
                    MessageBox.Show("Game is over!\nYou can restart the game with creating new players setting.");

                    // Show ranking on the list view
                    ShowRanking();

                    // User can set a game for a new game
                    EnableGrbGameSettings();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Enable game settings 
        private void EnableGrbGameSettings()
        {
            try
            {
                // User can set a new game
                grbGameSettings.Enabled = true;

                // Disable controls related to adding players
                DisableAddingPlayers();
                // User cannot play the game now
                grbRound.Enabled = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }           
        }

        // Enable to play game 
        private void EnableGrbRound()
        {
            try
            {
                // Now user can play a game
                grbRound.Enabled = true;

                // User cannot set a game
                grbGameSettings.Enabled = false;
                // User cannot add players
                DisableAddingPlayers();
            }
            catch (Exception ex)
            {

                throw ex;
            }           
        }

        // Disable group box [Players], so user cannot add new players 
        private void DisableAddingPlayers()
        {
            try
            {               
                // User cannot type new name for a player
                txtbNameOfPlayer.Enabled = false;
                // User cannot choose player avatar
                pbAvatars.Enabled = false;
                // User cannot add player
                btnAddPlayer.Enabled = false;
                // User cannot save players as favorite players
                chbSaveAsFavPlayers.Enabled = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }           
        }

        // Set 2 players for a round 
        private void SetPlayersForRound()
        {
            try
            {
                // Set 2 players who will play this round
                // These players are the first and second players in the queue
                currentP1 = myGameEngine.playerQueue.ElementAt(0);
                currentP2 = myGameEngine.playerQueue.ElementAt(1);

                // Show players' names of the round
                lblPlayer1Name.Text = currentP1.playerName;
                lblPlayer2Name.Text = currentP2.playerName;
                // Show players' image of the round
                pbPlayer1Avatar.Image = imglAvatars.Images[currentP1.playerAvatar];
                pbPlayer2Avatar.Image = imglAvatars.Images[currentP2.playerAvatar];

                // Set players' HP bar
                UpdateHPBar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Reset group box [Players] 
        private void ResetGrbPlayers()
        {
            try
            {
                // Refresh(Clear) the list view
                RefreshListView();
                // Reset the name of [Round] group box to default value
                grbRound.Text = "Round";
                // Reset [Name of player] label to default value
                lblNameOfPlayer.Text = "Name of player 1:";
                // Remove text in the name of player text box
                txtbNameOfPlayer.Text = "";
                // Reet the avatar list to default avatar
                pbAvatars.Image = imglAvatars.Images[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }          
        }

        // Reset group box [Round] 
        private void ResetGrbRound()
        {
            try
            {
                // Refresh players name to default value
                lblPlayer1Name.Text = "Player 1";
                lblPlayer2Name.Text = "Player 2";

                // Refresh players avatar to default value
                pbPlayer1Avatar.Image = null;
                pbPlayer2Avatar.Image = null;

                // Refresh players' HP bar to default value
                pgbPlayer1HP.Value = 0;
                pgbPlayer2HP.Value = 0;

                // Refresh players name to default value
                lblPlayer1HP.Text = "0";
                lblPlayer2HP.Text = "0";

                // Refresh players' decks image to default value
                pbPlayer1Deck.Image = null;
                pbPlayer2Deck.Image = null;

                // Refresh players current card info to default value
                lblP1Card.Text = "...";
                lblP2Card.Text = "...";

                // Refresh win/lose message to default value
                lblWinLoseMsg.Text = "...";

                // Remove the critical damage effects
                // Change players' name's back color to default value
                lblPlayer1Name.BackColor = Color.White;
                lblPlayer2Name.BackColor = Color.White;
                // Change win/lose message back color to default value
                lblWinLoseMsg.BackColor = Color.White;

                // Refresh and show the remaining cards 
                RefreshVisualRemainingCards();
            }
            catch (Exception ex)
            {
                throw ex;
            }          
        }

        // Refresh and show remaining cards 
        private void RefreshVisualRemainingCards()
        {
            try
            {
                // Refresh and show remaining draw cards visually
                pnlRemainingDrawCards.Height = pbDrawPile.Height + myGameEngine.drawPile.Count;
                // Refresh and show remaining players' card decks visually
                pnlRemainingP1Cards.Height = pbPlayer1Deck.Height + myGameEngine.p1Pile.Count;
                pnlRemainingP2Cards.Height = pbPlayer2Deck.Height + myGameEngine.p2Pile.Count;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // When a game window is opened 
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {   
                // Put the avatars image list into avatars option (picture box) and show
                pbAvatars.Image = imglAvatars.Images[imgIndex];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Refresh list view of remaining players 
        private void RefreshListView()
        {
            try
            {
                // Clear the previous remaining players on the list view
                lvRemainingPlayers.Items.Clear();

                // Show every players in the queue
                foreach (Player player in myGameEngine.playerQueue)
                {
                    // Create a new line for the list view
                    ListViewItem newLine = new ListViewItem();
                    // Player's avatar will be shown as a image index
                    newLine.ImageIndex = player.playerAvatar;
                    // Player name will be the first text of the line
                    newLine.Text = player.playerName;
                    // Write player's HP, wins, draws, loses in order
                    // Except the first text, other texts are subitems of the list
                    newLine.SubItems.Add(player.playerHP.ToString());
                    newLine.SubItems.Add(player.playerWins.ToString());
                    newLine.SubItems.Add(player.playerDraws.ToString());
                    newLine.SubItems.Add(player.playerLoses.ToString());

                    // Add the new line to the list view
                    lvRemainingPlayers.Items.Add(newLine);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }           
        }

        // Show ranking on the list view 
        private void ShowRanking()
        {
            try
            {
                // Position of the list view (ranking)
                byte position = 1;

                // Calculate players' score and rank players
                myGameEngine.RankPlayers();

                // Clear previous remaining players on the list view
                lvRemainingPlayers.Items.Clear();

                foreach (Player player in myGameEngine.players)
                {
                    // Create a new line for the list view
                    ListViewItem newLine = new ListViewItem();

                    // Change back color based on the positions
                    if (position == 1)
                    {   // Color of the first line become gold
                        newLine.BackColor = Color.Gold;
                    }
                    if (position == 2)
                    {   // Color of the first line become silver
                        newLine.BackColor = Color.Silver;
                    }
                    if (position == 3)
                    {   // Color of the first line become blanched almond
                        newLine.BackColor = Color.BlanchedAlmond;
                    }

                    // Player's avatar will be shown as a image index
                    newLine.ImageIndex = player.playerAvatar;
                    // Player name will be the first text of the line
                    newLine.Text = player.playerName;
                    // Write player's HP, wins, draws, loses in order
                    // Except the first text, other texts are subitems of the list
                    newLine.SubItems.Add(player.playerHP.ToString());
                    newLine.SubItems.Add(player.playerWins.ToString());
                    newLine.SubItems.Add(player.playerDraws.ToString());
                    newLine.SubItems.Add(player.playerLoses.ToString());

                    // Add the new line to the list view
                    lvRemainingPlayers.Items.Add(newLine);

                    // Increase position (+1)
                    position++;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }           
        }

        // When user clicks the avatar image: 
        private void picbAvatars_Click(object sender, EventArgs e)
        {
            try
            {
                // If the current image is the last one of the image list
                if (imgIndex >= imglAvatars.Images.Count - 1)
                {
                    // Go back to the first image
                    imgIndex = 0;
                }
                // If not
                else
                {
                    // Go to the next image
                    imgIndex++;
                }
                // The avatar image changes to the next avatar picture in the image list
                pbAvatars.Image = imglAvatars.Images[imgIndex];
            }
            catch (Exception ex)
            {
                throw ex;
            }       
        }

        // When user clicks the [Draw cards] button: 
        private void btnDrawCards_Click(object sender, EventArgs e)
        {
            try
            {
                // Remove the critical damage effect
                // Change players' name labels' back color to white (default)
                lblPlayer1Name.BackColor = Color.White;
                lblPlayer2Name.BackColor = Color.White;
                // Change win/lose message's back color to white (default)
                lblWinLoseMsg.BackColor = Color.White;

                // When the user checked [Use magic]
                if (chbUseMagic.Checked)
                {
                    // There are 6 chances out of 25 that a magic happens
                    // Get a random number
                    byte randomNumberForMagic = (byte)RNG.randomGenerator.Next(1, 26);

                    switch (randomNumberForMagic)
                    {
                        // If the random number is 1
                        case 1:
                            {   // Magic #1
                                MessageBox.Show("Magical storm!\nPlayers exchange their HP.");

                                // Players exchange their HP values
                                // Put current p1's HP into tempHP
                                byte tempHP = currentP1.playerHP;
                                // Put current p2's HP into p1's HP  => Now p1 has p2's HP
                                currentP1.playerHP = currentP2.playerHP;
                                // Put tempHP(p1's previous HP) into p2's HP  => Now p2 has p1's HP
                                currentP2.playerHP = tempHP;

                                // Update HP bar to show their HP visually
                                UpdateHPBar();

                                return;
                            }
                        // If the random number is 2
                        case 2:
                            {   // Magic #2
                                MessageBox.Show("Magical storm!\nPlayers get maximum HP.");

                                // Players' HP become to the maximum value.
                                currentP1.playerHP = maxHP;
                                currentP2.playerHP = maxHP;

                                // Update HP bar to show their HP visually
                                UpdateHPBar();

                                return;
                            }
                        // If the random number is 3
                        case 3:
                            {   // Magic #3
                                MessageBox.Show("Magical storm!\nHalf the missing HP of both players will be restored.");

                                // Restore half the missing HP of players
                                // If it's decimal number, round it to the previous number
                                // ex) 1.5 -> 1, so player's HP +1
                                currentP1.playerHP += (byte)Math.Truncate((decimal)(maxHP - currentP1.playerHP) / 2);
                                currentP2.playerHP += (byte)Math.Truncate((decimal)(maxHP - currentP2.playerHP) / 2);

                                // Update HP bar to show their HP visually
                                UpdateHPBar();

                                return;
                            }
                        // If the random number is 4
                        case 4:
                            {   // Magic #4
                                MessageBox.Show("Magical storm!\nPlayers lose half of their HP");

                                // Players lose half of their HP
                                // If it's decimal number, round it to the next number
                                // ex) 1.5 -> 2, so player's HP -2
                                currentP1.playerHP -= (byte)Math.Ceiling((decimal)currentP1.playerHP / 2);
                                currentP2.playerHP -= (byte)Math.Ceiling((decimal)currentP2.playerHP / 2);

                                // Update HP bar to show their HP visually
                                UpdateHPBar();

                                return;
                            }
                        // If the random number is 5
                        case 5:
                            {   // Magic #5
                                MessageBox.Show("Magical storm!\nThe damage will be tripled this time.");

                                // This will be checked later and make the next damage 3 times stronger
                                criticalDamage = true;

                                return;
                            }
                        // If the random number is 5
                        case 6:
                            {   // Magic #6
                                MessageBox.Show("Magical storm!\nBoth players will be moved at the end of the queue.");

                                // Send the 2 current players to the end of the queue
                                myGameEngine.playerQueue.Enqueue(myGameEngine.playerQueue.Dequeue());
                                myGameEngine.playerQueue.Enqueue(myGameEngine.playerQueue.Dequeue());
                                // Round number will increased by 1 without any win or lose
                                myGameEngine.roundNumber++;

                                // Refresh list view to show new player queue order
                                RefreshListView();
                                // Start the next round
                                StartRound();

                                return;
                            }
                    }
                }

                // When more than a card remain in the draw pile
                if (myGameEngine.drawPile.Count > 0)
                {
                    myGameEngine.DrawCards();

                    Card p1Card = myGameEngine.p1Pile.Peek();
                    Card p2Card = myGameEngine.p2Pile.Peek();

                    // Show players' current deck image
                    pbPlayer1Deck.Image = imglCards.Images[p1Card.cardImage];
                    pbPlayer2Deck.Image = imglCards.Images[p2Card.cardImage];

                    // Show players' current deck value
                    lblP1Card.Text = (Card.DisplayableCardValue(p1Card.cardValue) + " " + p1Card.cardType);
                    lblP2Card.Text = (Card.DisplayableCardValue(p2Card.cardValue) + " " + p2Card.cardType);

                    // Show remaining cards
                    RefreshVisualRemainingCards();

                    // If player1 lose a turn
                    if (p1Card.cardValue < p2Card.cardValue)
                    {
                        if (criticalDamage)
                        {
                            PlayerLoseTurnWithCriticalDamage(currentP1);
                            // Change P1's HP bar's color to red
                            lblPlayer1Name.BackColor = Color.Red;
                            // Turn off the critical damage
                            criticalDamage = false;
                        }
                        else
                        {
                            PlayerLoseTurn(currentP1);
                        }

                        // Update players' HP bar
                        UpdateHPBar();

                        if (currentP1.playerHP <= 0)
                        {
                            // Update players' wins and loses, and remove player1 from the queue
                            P1LoseRound();
                        }
                    }

                    // If player2 lose a turn
                    if (p1Card.cardValue > p2Card.cardValue)
                    {
                        if (criticalDamage)
                        {
                            PlayerLoseTurnWithCriticalDamage(currentP2);
                            // Change P1's HP bar's color to red
                            lblPlayer2Name.BackColor = Color.Red;
                            // Turn off the critical damage
                            criticalDamage = false;
                        }
                        else
                        {
                            PlayerLoseTurn(currentP2);
                        }

                        // Update players' HP bar
                        UpdateHPBar();

                        if (currentP2.playerHP <= 0)
                        {
                            // Update players' wins and loses, and remove player2 from the queue
                            P2LoseRound();
                        }
                    }

                    // If players current cards have the same value
                    if (p1Card.cardValue == p2Card.cardValue)
                    {
                        if (criticalDamage)
                        {
                            lblWinLoseMsg.BackColor = Color.Red;
                            lblWinLoseMsg.Text = "Draw! And the damage is critical. Both players lose 3 HP";

                            // Change players' HP bars' color to red
                            lblPlayer1Name.BackColor = Color.Red;
                            lblPlayer2Name.BackColor = Color.Red;

                            // Both players lose 3 HP
                            CriticalDamage(currentP1);
                            CriticalDamage(currentP2);

                            // Turn off the critical damage
                            criticalDamage = false;
                        }
                        else
                        {
                            PlayersDrawTurn();
                        }

                        // Update players' HP bar
                        UpdateHPBar();

                        if (currentP1.playerHP <= 0)
                        {
                            // If 2 players lost the game at the same time
                            if (currentP2.playerHP <= 0)
                            {
                                PlayersDrawRound();
                            }
                            else
                            {
                                P1LoseRound();
                            }
                        }
                        if (currentP2.playerHP <= 0)
                        {
                            P2LoseRound();
                        }
                    }
                }
                // When the draw pile is empty
                else
                {
                    MessageBox.Show("Draw pile is empty.\nReshuffling...");
                    myGameEngine.ShuffleCards();
                    RefreshVisualRemainingCards();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }           
        }

        // When a player lose a turn and get critical damage 
        private void PlayerLoseTurnWithCriticalDamage(Player loser)
        {
            try
            {
                // This is for critical damage effect
                lblWinLoseMsg.BackColor = Color.Red;

                // Show a special lose message
                lblWinLoseMsg.Text = loser.playerName + " lost! And it was critical! (hp -3)";
                // Give critical damage to the loser
                CriticalDamage(loser);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Give a critical damage to a loser 
        private void CriticalDamage(Player loser)
        {
            try
            {
                // loser's HP -3
                loser.playerHP -= 3;
                // Prevent player's HP going down than 0
                if (loser.playerHP <= 0)
                {   // If loser's HP is lower than 0, make it 0 to prevent error
                    loser.playerHP = 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // When a player lose a turn (normally, without magic) 
        private void PlayerLoseTurn(Player loser)
        {
            try
            {
                // Show message that loser lost 1 HP
                lblWinLoseMsg.Text = loser.playerName + " lost! (hp -1)";
                // They lose their 1 HP
                loser.playerHP--;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // When players are draw for a turn (not a round) 
        private void PlayersDrawTurn()
        {
            try
            {   // Show message that each players lost 1 HP
                lblWinLoseMsg.Text = "Draw! Both players lose 1 HP";
                // Each players lose 1 HP
                currentP1.playerHP--;
                currentP2.playerHP--;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // When players are draw for a round 
        private void PlayersDrawRound()
        {
            try
            {   // The round is over
                MessageBox.Show("This round is over.\nIt's a draw.");
                // Both players got 1 point for draws
                currentP1.playerDraws++;
                currentP2.playerDraws++;

                // If user checked [Use magic]
                if (chbUseMagic.Checked)
                {   // Wizard's luck is occured
                    MessageBox.Show("Wizard's luck is occured!");

                    // Add 3 HP to both of the players
                    currentP1.playerHP += 3;
                    currentP2.playerHP += 3;

                    // Send the players to the end of the queue
                    myGameEngine.playerQueue.Enqueue(myGameEngine.playerQueue.Dequeue());
                    myGameEngine.playerQueue.Enqueue(myGameEngine.playerQueue.Dequeue());
                }
                // If user didn't check [Use magic]
                else
                {
                    // Remove p1 from the player queue
                    myGameEngine.playerQueue.Dequeue();
                    // Remove p2 from the player queue
                    myGameEngine.playerQueue.Dequeue();
                }

                // Start the next round
                StartRound();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // When (current) player 1 lose a round 
        private void P1LoseRound()
        {
            try
            {
                // Show who is winner and who is loser
                MessageBox.Show("This round is over.\n" + currentP2.playerName + " won the round.");
                // p1 gets 1 lose point
                currentP1.playerLoses++;
                // p2 gets 1 win point
                currentP2.playerWins++;

                // If user checked [Use magic]
                if (chbUseMagic.Checked)
                {
                    // Magic effect: Stamina is occured to the p2
                    Stamina(currentP2);
                }

                // Remove p1 from the player queue
                myGameEngine.playerQueue.Dequeue();
                // Move p2 to the end of the queue
                myGameEngine.playerQueue.Enqueue(myGameEngine.playerQueue.Dequeue());

                // Start the next round
                StartRound();
            }
            catch (Exception ex)
            {
                throw ex;
            }           
        }

        // Magical effect: Winner gets 5 HP after the round 
        private void Stamina(Player winner)
        {
            try
            {
                // Let user know the magical effect(Stamina) happened
                MessageBox.Show("Magical effect: Stamina! Winner gets 5 HP");

                // Winner's HP +5
                winner.playerHP += 5;

                // Prevent player's HP goes up than max HP set
                // If winner's HP is higher than max HP set
                if (winner.playerHP > nudMaxHP.Value)
                {
                    // The winner's HP is equal to max HP set
                    winner.playerHP = maxHP;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }          
        }

        // When (current) player 2 lose a round 
        private void P2LoseRound()
        {
            try
            {
                // Show who is winner and who is loser
                MessageBox.Show("This round is over.\n" + currentP1.playerName + " won the round.");
                // p2 gets 1 lose point
                currentP2.playerLoses++;
                // P1 gets 1 win point
                currentP1.playerWins++;

                // If the game is magic mode
                if (chbUseMagic.Checked)
                {
                    // Magic effect: Stamina occurs to p1(winner)
                    Stamina(currentP1);
                }

                // Move p1 to the end of the queue
                myGameEngine.playerQueue.Enqueue(myGameEngine.playerQueue.Dequeue());
                // Remove p2 from the player queue
                myGameEngine.playerQueue.Dequeue();

                // Start the next round
                StartRound();
            }
            catch (Exception ex)
            {
                throw ex;
            }          
        }

        // Update visual HP of players for a round 
        private void UpdateHPBar()
        {
            try
            {   // Update 2 current players HP bar with their current HP values
                pgbPlayer1HP.Value = currentP1.playerHP;
                pgbPlayer2HP.Value = currentP2.playerHP;
                // Update texts saying each players' HP values
                lblPlayer1HP.Text = currentP1.playerHP.ToString();
                lblPlayer2HP.Text = currentP2.playerHP.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
