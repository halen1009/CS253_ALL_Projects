using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WalkingElsa
{
    internal class Person
    {
        #region 宣告Person的欄位: Name, Velovity, face, StartPosition, Position, turnPoint, elsaImagePictureBox, animationTimer, elsaTrack

        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        private float velocity;

        public float Velocity
        {
            get { return velocity; }
            set
            {
                if (value < 0) velocity = 0;
                else if (value > 1000) velocity = 1000;
                else velocity = value;
            }
        }

        private double faceDirection;

        public double FaceDirection
        {
            get { return faceDirection; }
            set
            {
                if (faceDirection < 0) faceDirection = 0;
                else if (faceDirection > 360) faceDirection = 360;
                else faceDirection = value;
            }
        }

        private Position startPosition;

        public Position StartPosition
        {
            get { return startPosition; }
            set { startPosition = value; }
        }

        private Position position;

        private Position turnPoint;

        public System.Windows.Forms.PictureBox elsaImagePictureBox;

        public System.Windows.Forms.Timer animationTimer;

        public Track elsaTrack;

        #endregion 宣告Person的欄位: Name, Velovity, face, StartPosition, Position, turnPoint, elsaImagePictureBox, animationTimer, elsaTrack

        public Person()
        {
            this.startPosition = new Position() { X = 112, Y = 12 };
            this.position = new Position() { X = startPosition.X, Y = startPosition.Y };
            turnPoint = new Position() { X = startPosition.X, Y = startPosition.Y };
            //turnPoint = startPosition;
            //position = startPosition;
            this.elsaImagePictureBox = new System.Windows.Forms.PictureBox()

            #region elsaImagePictureBox的初始值

  {
      Image = global::WalkingElsa.Properties.Resources.tumblr_muexn83y6t1s0h0fgo1_500,
      Location = new System.Drawing.Point(startPosition.X, startPosition.Y),
      Margin = new System.Windows.Forms.Padding(4, 4, 4, 4),
      Name = "elsaImagePictureBox",
      Size = new System.Drawing.Size(80, 111),
      SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage,
      TabIndex = 0,
      TabStop = false
  };

            #endregion elsaImagePictureBox的初始值

            this.elsaTrack = new Track();
            elsaTrack.points.Add(elsaImagePictureBox.Location);
            this.animationTimer = new Timer();
        }

        public Position changeDirection(int turn)
        {
            faceDirection = (faceDirection + turn) % 360;
            //turnPoint = position;

            turnPoint.X = position.X;
            turnPoint.Y = position.Y;
            //turnPoint = this.position;
            return this.position;
        }

        public Position Walk()
        {
            double distance = Math.Sqrt(Math.Abs(position.X - turnPoint.X) * Math.Abs(position.X - turnPoint.X) + Math.Abs(position.Y - turnPoint.Y) * Math.Abs(position.Y - turnPoint.Y));
            if (distance < Form1.distanceLimit)
            {
                float dx = velocity * (float)Math.Cos(Math.PI / 180 * FaceDirection) * animationTimer.Interval / 1000.0f;
                float dy = velocity * (float)Math.Sin(Math.PI / 180 * FaceDirection) * animationTimer.Interval / 1000.0f;
                //return UpdateElsaPosition(dx, dy);
                position.X += (int)dx;
                position.Y += (int)dy;
                elsaImagePictureBox.Location = new Point(position.X, position.Y);
                elsaTrack.points.Add(elsaImagePictureBox.Location);
                return this.position;
            }
            else
            {
                //animationTimer.Enabled = false;
                changeDirection(90);

                return this.position;
            }
        }

        //public void Walk(Position turnPoint)
        //{
        //    double distance = 0;

        //    float dx = velocity * (float)Math.Cos(Face) * animationTimer.Interval / 1000.0f;
        //    float dy = velocity * (float)Math.Sin(Face) * animationTimer.Interval / 1000.0f;
        //    UpdateElsaPosition(dx, dy);

        //    distance = Math.Sqrt(Math.Abs(position.X - turnPoint.X) * Math.Abs(position.X - turnPoint.X) + Math.Abs(position.Y - turnPoint.Y) * Math.Abs(position.Y - turnPoint.Y));
        //    if (distance > endPosition.X)
        //        animationTimer.Enabled = !animationTimer.Enabled;
        //}

        //public Position UpdateElsaPosition(float dx, float dy)
        //{
        //    this.position.X += (int)dx;
        //    this.position.Y += (int)dy;
        //    elsaImagePictureBox.Location = new Point(position.X, position.Y);
        //    elsaTrack.points.Add(elsaImagePictureBox.Location);
        //    return this.position;
        //}

        public void animationTimer_Tick(object sender, EventArgs e)
        {
            Walk();
        }

        //public void MoveForward()
        //{
        //    Position turnPoint = new Position();
        //    turnPoint = position;
        //    //Walk(turnPoint);
        //}

        public void Rectangular()
        {
            ////double distance = 0;
            //distance = 0;
            //Position turnPoint = new Position();
            //turnPoint = position;

            //animationTimer.Enabled = true;
            //distance = Math.Sqrt(Math.Abs(position.X - turnPoint.X) * Math.Abs(position.X - turnPoint.X) + Math.Abs(position.Y - turnPoint.Y) * Math.Abs(position.Y - turnPoint.Y));

            //if (distance > endPosition.X)
            //    animationTimer.Enabled = !animationTimer.Enabled;
            //Walk(turnPoint);

            animationTimer.Enabled = true;
            turnPoint = changeDirection(180);
            //turnPoint = position;
            //Walk(turnPoint);
            //for (int i = 0; i < 4; i++)
            //{
            //while (distance < endPosition.X)
            //{
            //Walk();
            ////distance = Math.Sqrt(Math.Abs(position.X - turnPoint.X) * Math.Abs(position.X - turnPoint.X) + Math.Abs(position.Y - turnPoint.Y) * Math.Abs(position.Y - turnPoint.Y));
            ////};
            ////if((Math.Sqrt(Math.Abs(position.X - turnPoint.X) * Math.Abs(position.X - turnPoint.X) + Math.Abs(position.Y - turnPoint.Y) * Math.Abs(position.Y - turnPoint.Y))>endPosition.X)
            //if (position.X > endPosition.X)
            //    changeDirection(180);
            //Walk();
            //}
        }

        //public void InitializeImage()
        //{
        //    elsaImagePictureBox.Image = global::WalkingElsa.Properties.Resources.tumblr_muexn83y6t1s0h0fgo1_500;
        //    elsaImagePictureBox.Location = new System.Drawing.Point(12, 12);
        //    elsaImagePictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
        //    elsaImagePictureBox.Name = "elsaImagePictureBox";
        //    elsaImagePictureBox.Size = new System.Drawing.Size(80, 111);
        //    elsaImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        //    elsaImagePictureBox.TabIndex = 0;
        //    elsaImagePictureBox.TabStop = false;
        //    //Form1.Controls.Add(elsaImagePictureBox);
        //}
    }
}