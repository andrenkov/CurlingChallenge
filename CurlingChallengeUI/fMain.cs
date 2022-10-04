using CurlingChallenge;
using CurlingChallenge.Models;

namespace CurlingChallengeUI
{
    public partial class fMain : Form
    {
        private int width { get; set; }
        private double height { get; set; }
        private int n { get; set; }
        private int r { get; set; }
        private List<CurlingRock> disks { get; set; }

        public fMain()
        {
            InitializeComponent();
            Init();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Start playing disks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btPlay_Click(object sender, EventArgs e)
        {
            Init();

            lbStatus.Text = "Playing ...";
            try
            {
                game g = new game(width, height, r, disks);
                g.PlayGame();
                lbStatus.Text = "Game over";

                if (g.disksList.Count > 0)
                {
                    DisplayResult(g.disksList);
                }

            }
            catch (Exception ex)
            {
                lbStatus.Text = $"Error - {ex.Message}";
            }

        }
        /// <summary>
        /// Drawing disks on the panel
        /// </summary>
        /// <param name="disksList"></param>
        private void DisplayResult(List<CurlingRock> disksList)
        {
            double factor = 1;

            List<CurlingRock> sizeDisks = disksList
                .OrderByDescending(d => d.endPos.X)
                .ToList();
            //factor still require more attention for the proper dpi to pixel scaling
            //I just use the solution that produces an OK result for now 
            factor = pnlView.Width / 2 / sizeDisks[0].endPos.X;//use the most right disk position


            foreach (CurlingRock disk in disksList)
            {
                lbxResult.Items.Add(string.Format("y={0}; x={1}", disk.endPos.Y, disk.endPos.X));
                DrawCircle(disk.endPos, factor);
            }

            Invalidate();
        }
        /// <summary>
        ///  Drawing circles
        /// </summary>
        /// <param name="coord"></param>
        /// <param name="factor"></param>
        private void DrawCircle(Coords coord, double factor)
        {
            SolidBrush myBrush = new SolidBrush(Color.Red);
            Graphics formGraphics = Graphics.FromHwnd(pnlView.Handle);

            double x = factor == 1 ? coord.X : coord.X * factor;
            double y = factor == 1 ? coord.Y : coord.Y * factor;
            double rad = factor == 1 ? r * 2 : r * 2 * factor;

            x = x + rad / 2 + pnlControls.Width;
            y = y - rad / 2 + pnlView.Top;

            try
            {
                formGraphics.FillEllipse(myBrush, new Rectangle((int)x, (int)y, (int)rad, (int)rad));
            }
            catch
            {
            }
            finally
            {
                myBrush.Dispose();
                formGraphics.Dispose();
            }

        }
        /// <summary>
        /// Init inputs and status
        /// </summary>
        private void Init()
        {
            lbStatus.Text = "";
            lbxResult.Items.Clear();
            try
            {
                width = 1000;
                height = Math.Pow(10, 100);
                n = (int)edNumDisks.Value;
                r = (int)edDiskRadius.Value;

                Random randNum = new Random();
                int[] xCoordinates = Enumerable
                    .Repeat(0, n)
                    .Select(i => randNum.Next(r, width))
                    .ToArray();

                disks = new();
                foreach (int diskX in xCoordinates)
                {

                    Coords startCoords = new(diskX, height);
                    CurlingRock CurlDisk = new(r, startCoords);
                    disks.Add(CurlDisk);
                }
            }
            catch
            {
                lbStatus.Text = "Input error";
                return;
            }

            btPlay.Enabled = true;
        }
        /// <summary>
        /// Removed graphics from the panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btClear_Click(object sender, EventArgs e)
        {
            pnlView.Invalidate();
        }
    }
}