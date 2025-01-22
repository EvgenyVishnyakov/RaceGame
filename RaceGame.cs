using System;
using System.Media;
using System.Windows.Forms;

namespace Race;
public partial class RaceGame : Form
{
    private SoundPlayer _soundplayer;
    public User user;
    Label[] LanesOne = new Label[5];
    Label[] LanesTwo = new Label[5];
    Label[] LanesMenuOne = new Label[5];
    Label[] LanesMenuTwo = new Label[5];
    Random random = new Random();

    public string korrectAmountOfScores;
    private int AmountOfScores = 0;
    private int carSpeed = 2;
    private int verticalSpeed = 10;
    private int cointsChange = 15;
    private string sound = @"Resources\Super_Mario.wav";

    public RaceGame()
    {
        InitializeComponent();
        StartPosition = FormStartPosition.CenterScreen;
        _soundplayer = new SoundPlayer(sound);
    }

    private void GetMusic()
    {
        _soundplayer.PlayLooping();
    }

    private void RaceGame_Load(object sender, EventArgs e)
    {
        GetMusic();
        GetLanesOne();
        GetLanesTwo();
        GetLanesMenuOne();
        GetLanesMenuTwo();

        timerRoad.Stop();
        timerTowardCars.Stop();
        panelMenu.Show();
    }

    private void timerRoad_Tick(object sender, EventArgs e)
    {
        labelCoins.Text = "Coins: " + user.AmountOfCoins;
        labelScore.Text = "Score: " + korrectAmountOfScores;
        for (int i = 0; i < LanesOne.Length; ++i)
        {
            LanesOne[i].Top += carSpeed;
            if (LanesOne[i].Top >= Height)
            {
                LanesOne[i].Top = -LanesOne[i].Height;
            }
            if (carSpeed != 0)
            {
                AmountOfScores++;
                korrectAmountOfScores = "" + AmountOfScores / 10;
                user.GetScores(korrectAmountOfScores);
            }
        }

        for (int i = 0; i < LanesTwo.Length; ++i)
        {
            LanesTwo[i].Top += carSpeed;
            if (LanesTwo[i].Top >= Height)
            {
                LanesTwo[i].Top = -LanesTwo[i].Height;
            }
        }
        Coin_1();
        Coin_2();
        Coin_3();
        coinsCollect();
    }

    private void Coin_3()
    {
        Coin3.Top += carSpeed;
        if (Coin3.Top > Height)
        {
            Coin3.Top = -Coin3.Height;
            Coin3.Left = random.Next(1, panelGame.Width - 3 * Coin3.Width);
        }
    }

    private void Coin_2()
    {
        Coin2.Top += carSpeed;
        if (Coin2.Top > Height)
        {
            Coin2.Top = -Coin2.Height;
            Coin2.Left = random.Next(1, panelGame.Width - 3 * Coin2.Width);
        }
    }

    private void Coin_1()
    {
        Coin1.Top += carSpeed;
        if (Coin1.Top > Height)
        {
            Coin1.Top = -Coin1.Height;
            Coin1.Left = random.Next(1, panelGame.Width - 3 * Coin1.Width);
        }
    }

    void coinsCollect()
    {
        IsBoundsCoin1();
        IsBoundsCoin2();
        IsBoundCoin3();
    }

    private void IsBoundCoin3()
    {
        if (mainCar.Bounds.IntersectsWith(Coin3.Bounds))
        {
            user.GetCoins();
            labelCoins.Text = "Coins: " + user.AmountOfCoins;
            Coin3.Top = -Coin3.Height;
            Coin3.Left = placementCoins();
        }
    }

    private void IsBoundsCoin2()
    {
        if (mainCar.Bounds.IntersectsWith(Coin2.Bounds))
        {
            user.GetCoins();
            labelCoins.Text = "Coins: " + user.AmountOfCoins;
            Coin2.Top = -Coin2.Height;
            Coin2.Left = placementCoins();
        }
    }
    private void IsBoundsCoin1()
    {
        if (mainCar.Bounds.IntersectsWith(Coin1.Bounds))
        {
            user.GetCoins();
            labelCoins.Text = "Coins: " + user.AmountOfCoins;
            Coin1.Top = -Coin1.Height;
            Coin1.Left = placementCoins();
        }
    }
    private int placementCoins()
    {
        return random.Next(1, panelGame.Width - 3 * Coin1.Width);
    }
    private void GetLanesMenuTwo()
    {
        LanesMenuTwo[0] = MenuTwoLane1;
        LanesMenuTwo[1] = MenuTwoLane2;
        LanesMenuTwo[2] = MenuTwoLane3;
        LanesMenuTwo[3] = MenuTwoLane4;
        LanesMenuTwo[4] = MenuTwoLane5;
    }
    private void GetLanesMenuOne()
    {
        LanesMenuOne[0] = MenuOneLane1;
        LanesMenuOne[1] = MenuOneLane2;
        LanesMenuOne[2] = MenuOneLane3;
        LanesMenuOne[3] = MenuOneLane4;
        LanesMenuOne[4] = MenuOneLane5;
    }
    private void GetLanesTwo()
    {
        LanesTwo[0] = LaneTwo1;
        LanesTwo[1] = LaneTwo2;
        LanesTwo[2] = LaneTwo3;
        LanesTwo[3] = LaneTwo4;
        LanesTwo[4] = LaneTwo5;
    }
    private void GetLanesOne()
    {
        LanesOne[0] = LaneOne1;
        LanesOne[1] = LaneOne2;
        LanesOne[2] = LaneOne3;
        LanesOne[3] = LaneOne4;
        LanesOne[4] = LaneOne5;
    }
    private void RaceGame_KeyDown(object sender, KeyEventArgs e)
    {
        IsMoveCar(e);
        IsMoveUp(e);
        IsMoveDown(e);
        IsMoveEscape(e);
    }
    private void IsMoveEscape(KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Escape)
        {
            timerRoad.Enabled = false;
            timerTowardCars.Enabled = false;
            panelPause.Show();
        }
    }
    private void IsMoveDown(KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Down)
        {
            if (carSpeed > 0)
                carSpeed--;
        }
    }
    private void IsMoveUp(KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Up)
        {
            if (carSpeed < 21)
            {
                carSpeed++;
            }
        }
    }
    private void IsMoveCar(KeyEventArgs e)
    {
        if (carSpeed != 0)
        {
            GetMoveRight(e);
            GetMoveLeft(e);
        }
    }
    private void GetMoveLeft(KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Left)
        {
            mainCar.Left -= verticalSpeed;
            if (mainCar.Left < -mainCar.Width / 2)
            {
                mainCar.Left = panelMenu.Width - mainCar.Width / 2;
            }
        }
    }
    private void GetMoveRight(KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Right)
        {
            mainCar.Left += verticalSpeed;
            if (mainCar.Right >= panelMenu.Width + mainCar.Width / 2)
            {
                mainCar.Left = -mainCar.Width / 2;
            }
        }
    }
    private void timerTowardCars_Tick(object sender, EventArgs e)
    {
        GetTowards1(e);
        GetTowards2(e);
        GetTowards3(e);
        GetCarBoundsTowards(e);
    }
    private void GetCarBoundsTowards(EventArgs e)
    {
        if (IsMainCareBoundsTowards1())
        {
            GameOver(e);
        }
        if (IsMainCarBoundsTowards2())
        {
            GameOver(e);
        }
        if (IsMainCarBoundsTowards3())
        {
            GameOver(e);
        }
    }
    private void GetTowards3(EventArgs e)
    {
        towardCar3.Top += carSpeed + random.Next(3, 5);
        if (towardCar3.Top > Height)
        {
            GetPlacementTowards3(e);
        }
    }
    private void GetPlacementTowards3(EventArgs e)
    {
        towardCar3.Top = -towardCar3.Height;
        towardCar3.Left = random.Next(Math.Abs(panelMenu.Width - GetTowards2Koordinate(e)));
    }
    private void GetTowards2(EventArgs e)
    {
        towardCar2.Top += carSpeed + random.Next(1, 3);
        if (towardCar2.Top > Height)
        {
            GetPlacementTowards2(e);
        }
    }
    private void GetPlacementTowards2(EventArgs e)
    {
        towardCar2.Top = -towardCar2.Height;
        towardCar2.Left = random.Next(Math.Abs(panelMenu.Width - GetTowards1Koordinate(e)));
    }
    private void GetTowards1(EventArgs e)
    {
        towardCar1.Top += carSpeed + random.Next(4, 8);
        if (towardCar1.Top > Height)
        {
            GetPlacementTowards1(e);
        }
    }
    private void GetPlacementTowards1(EventArgs e)
    {
        towardCar1.Top = -towardCar1.Height;
        towardCar1.Left = random.Next(Math.Abs(panelMenu.Width - GetTowards3Koordinate(e)));
    }
    private int GetTowards1Koordinate(EventArgs e)
    {
        return towardCar1.Location.X;
    }
    private int GetTowards2Koordinate(EventArgs e)
    {
        return towardCar2.Location.X;
    }
    private int GetTowards3Koordinate(EventArgs e)
    {
        return towardCar3.Location.X;
    }
    private bool IsMainCarBoundsTowards3()
    {
        return mainCar.Bounds.IntersectsWith(towardCar3.Bounds);
    }
    private bool IsMainCarBoundsTowards2()
    {
        return mainCar.Bounds.IntersectsWith(towardCar2.Bounds);
    }
    private bool IsMainCareBoundsTowards1()
    {
        return mainCar.Bounds.IntersectsWith(towardCar1.Bounds);
    }
    private void GameOver(EventArgs e)
    {
        carSpeed = 0;
        timerRoad.Stop();
        timerTowardCars.Stop();
        if (user.AmountOfCoins < cointsChange)
        {
            MessageBox.Show("Game Over!", "Приехали!");
            GetResult();
            panelPause.Show();
            panelMenu.Show();
        }
        else
        {
            DialogResult dialogResult = MessageBox.Show($"Продолжить? (-{cointsChange} coins)", "Приехали!",
            MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                Restart(e);
            else if (dialogResult == DialogResult.No)
            {
                GetResult();
                panelPause.Show();
                panelMenu.Show();
            }
        }
    }
    private void Restart(EventArgs e)
    {
        user.AmountOfCoins -= cointsChange;
        labelCoins.Text = "Coins: " + user.AmountOfCoins;
        timerRoad.Start();
        timerTowardCars.Start();
        GetPlacementTowards1(e);
        GetPlacementTowards2(e);
        GetPlacementTowards3(e);
    }
    private void StartGame(EventArgs e)
    {
        AmountOfScores = 0;
        user.AmountOfCoins = 0;
        carSpeed = 2;
        user.GetDate();
        timerRoad.Start();
        timerTowardCars.Start();
        GetPlacementTowards1(e);
        GetPlacementTowards2(e);
        GetPlacementTowards3(e);
        panelPause.Hide();
        panelGame.Show();
        panelMenu.Hide();
    }
    public string GetResult()
    {
        var value = $"{user.Name}, Вы набрали {korrectAmountOfScores.ToString()} очков , собрали {user.AmountOfCoins} монет";
        MessageBox.Show(value);
        UserStorage.SaveUserResult(user);
        return value;
    }
    private void timerMenu_Tick(object sender, EventArgs e)
    {
        for (int i = 0; i < LanesMenuOne.Length; ++i)
        {
            LanesMenuOne[i].Top += carSpeed;
            if (LanesMenuOne[i].Top >= Height)
            {
                LanesMenuOne[i].Top = -LanesMenuOne[i].Height;
            }
        }
        for (int i = 0; i < LanesMenuTwo.Length; ++i)
        {
            LanesMenuTwo[i].Top += carSpeed;
            if (LanesMenuTwo[i].Top >= Height)
                LanesMenuTwo[i].Top = -LanesMenuTwo[i].Height;
        }
        CarMenu1.Top += 5;
        if (CarMenu1.Top > Height)
        {
            CarMenu1.Top = -CarMenu1.Height;
            CarMenu1.Left = random.Next(0, Width - CarMenu1.Width);
        }
        CarMenu2.Top += 3;
        if (CarMenu2.Top > Height)
        {
            CarMenu2.Top = -CarMenu2.Height;
            CarMenu2.Left = random.Next(0, Width - CarMenu2.Width);
        }
        CarMenu3.Top += 4;
        if (CarMenu3.Top > Height)
        {
            CarMenu3.Top = -CarMenu3.Height;
            CarMenu3.Left = random.Next(0, Width - CarMenu3.Width);
        }
    }
    private void buttonPause_Click(object sender, EventArgs e)
    {
        timerRoad.Enabled = false;
        timerTowardCars.Enabled = false;
        panelPause.Show();
    }
    private void buttonResume_Click(object sender, EventArgs e)
    {
        timerRoad.Enabled = true;
        timerTowardCars.Enabled = true;
        panelPause.Hide();
    }
    private void buttonExit_Click(object sender, EventArgs e)
    {
        panelMenu.Show();
    }
    private void buttonStart_Click(object sender, EventArgs e)
    {
        StartGame(e);
        panelGame.Show();
        panelMenu.Hide();
    }
    private void buttonMenuExit_Click(object sender, EventArgs e)
    {
        this.Close();
    }
    private void button1_Click(object sender, EventArgs e)
    {
        RulesForm rulesForm = new RulesForm();
        rulesForm.Show();
    }
    private void button2_Click(object sender, EventArgs e)
    {
        ResultsForm resultsForm = new ResultsForm();
        resultsForm.Show();
    }
}

