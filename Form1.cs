using Algorithm_design_Imp.algoritms;
using Algorithm_design_Imp.baseImp;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace Algorithm_design_Imp
{


    public partial class Form1 : Form
    {
        public static Graph graph; // data todo


        public void addTmp()
        {
            var node = new Node("A", new Point(300, 100), 0);
            graph.AddNode(node);
            node = new Node("B", new Point(400, 200), 0);
            graph.AddNode(node);
            node = new Node("C", new Point(400, 400), 0);
            graph.AddNode(node);
            node = new Node("D", new Point(550, 300), 0);
            graph.AddNode(node);
            node = new Node("E", new Point(700, 200), 0);
            graph.AddNode(node);
            node = new Node("F", new Point(300, 400), 0);
            graph.AddNode(node);

            graph.AddEdge(new Edge(graph.GetNodeByName("A"), graph.GetNodeByName("D"), 9, false));
            graph.AddEdge(new Edge(graph.GetNodeByName("A"), graph.GetNodeByName("B"), 3, false));
            graph.AddEdge(new Edge(graph.GetNodeByName("A"), graph.GetNodeByName("C"), 5, false));

            graph.AddEdge(new Edge(graph.GetNodeByName("B"), graph.GetNodeByName("D"), 4, false));
            graph.AddEdge(new Edge(graph.GetNodeByName("B"), graph.GetNodeByName("E"), 7, false));
            graph.AddEdge(new Edge(graph.GetNodeByName("B"), graph.GetNodeByName("C"), 3, false));




            graph.AddEdge(new Edge(graph.GetNodeByName("C"), graph.GetNodeByName("D"), 2, false));
            graph.AddEdge(new Edge(graph.GetNodeByName("C"), graph.GetNodeByName("E"), 6, false));

            graph.AddEdge(new Edge(graph.GetNodeByName("D"), graph.GetNodeByName("F"), 2, false));
            graph.AddEdge(new Edge(graph.GetNodeByName("D"), graph.GetNodeByName("E"), 2, false));

            graph.AddEdge(new Edge(graph.GetNodeByName("E"), graph.GetNodeByName("F"), 5, false));

            graph.AddEdge(new Edge(graph.GetNodeByName("F"), graph.GetNodeByName("C"), 8, false));

            Invalidate();
        }

        private Point _dragStartPoint;
        private bool _isDragging = false;
        private Node _draggedNode = null;
        private Node _selectedNode = null;
        public Form1()
        {
            InitializeComponent();
            graph = new Graph();
            this.MouseDown += Form1_MouseDown;
            this.MouseMove += Form1_MouseMove;
            this.MouseUp += Form1_MouseUp;
            this.DoubleClick += Form1_DoubleClick;
        }

        private void Form1_DoubleClick(object? sender, EventArgs e)
        {
            MouseEventArgs mouseArgs = e as MouseEventArgs;
            if (mouseArgs != null)
            {
                _selectedNode = GetNodeAtPosition(mouseArgs.Location);
                if (_selectedNode != null && _isDragging)
                {
                    addNode editForm = new addNode(this, _selectedNode);
                    editForm.ShowDialog();
                }
                else
                {
                    Edge selectedEdge = GetEdgeAtPosition(mouseArgs.Location);
                    if (selectedEdge != null)
                    {
                        addEdge editEdgeForm = new addEdge(this, selectedEdge);
                        editEdgeForm.ShowDialog();
                    }
                }
            }
        }

        private void btnAddNode_Click(object sender, EventArgs e)
        {
            addNode addNode = new addNode(this, null);
            addNode.ShowDialog();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            foreach (var edge in graph.Edges)
            {
                var fromPosition = GetEdgeStartPosition(edge.From.Position, edge.To.Position);
                var toPosition = GetEdgeEndPosition(edge.From.Position, edge.To.Position);

                g.DrawLine(Pens.Black, fromPosition, toPosition);

                if (edge.isDirected)
                    DrawArrow(g, fromPosition, toPosition);

                var middlePoint = new Point((fromPosition.X + toPosition.X) / 2,
                                            (fromPosition.Y + toPosition.Y) / 2);
                g.DrawString(edge.Weight.ToString(), this.Font, Brushes.Red, middlePoint);
            }

            foreach (var node in graph.Nodes)
            {
                Font stName = new Font("nullName", 12);
                g.FillEllipse(Brushes.Blue, node.Position.X - 10, node.Position.Y - 10, 35, 35);
                g.DrawString(node.Name, stName, Brushes.White, node.Position.X, node.Position.Y);
            }
        }
        private Edge GetEdgeAtPosition(Point location)
        {
            foreach (var edge in Form1.graph.Edges)
            {
                double distance = GetDistanceFromPointToLine(edge.From.Position, edge.To.Position, location);
                if (distance <= 5)
                {
                    return edge;
                }
            }
            return null;
        }


        private double GetDistanceFromPointToLine(Point lineStart, Point lineEnd, Point point)
        {

            double numerator = Math.Abs((lineEnd.Y - lineStart.Y) * point.X - (lineEnd.X - lineStart.X) * point.Y + lineEnd.X * lineStart.Y - lineEnd.Y * lineStart.X);
            double denominator = Math.Sqrt(Math.Pow(lineEnd.Y - lineStart.Y, 2) + Math.Pow(lineEnd.X - lineStart.X, 2));
            return numerator / denominator;
        }


        private Point GetEdgeStartPosition(Point from, Point to)
        {

            double angle = Math.Atan2(to.Y - from.Y, to.X - from.X);


            int offset = 1;

            return new Point((int)(from.X + offset * Math.Cos(angle)),
                             (int)(from.Y + offset * Math.Sin(angle)));
        }

        private Point GetEdgeEndPosition(Point from, Point to)
        {
            double angle = Math.Atan2(to.Y - from.Y, to.X - from.X);


            int offset = 20;
            //blbMeasuare.Text = "x= " + ( to.X - offset).ToString() + "   y = " + (to.Y - offset);

            //return new Point((int)(to.X - offset * Math.Abs(Math.Cos(angle))),
            //                 (int)(to.Y - offset * Math.Abs(Math.Sin(angle))));
            return new Point((int)(to.X - offset * Math.Cos(angle)),
                             (int)(to.Y - offset * Math.Sin(angle)));
        }
        private void DrawArrow(Graphics g, Point from, Point to)
        {
            double angle = Math.Atan2(from.Y - to.Y, from.X - to.X);

            float arrowLength = 10;
            float arrowWidth = 10;

            PointF arrowTip = new PointF((float)(to.X - arrowLength * Math.Cos(angle)),
                                          (float)(to.Y - arrowLength * Math.Sin(angle)));

            PointF leftWing = new PointF((float)(arrowTip.X + arrowWidth * Math.Cos(angle - Math.PI / 6)),
                                          (float)(arrowTip.Y + arrowWidth * Math.Sin(angle - Math.PI / 6)));
            PointF rightWing = new PointF((float)(arrowTip.X + arrowWidth * Math.Cos(angle + Math.PI / 6)),
                                          (float)(arrowTip.Y + arrowWidth * Math.Sin(angle + Math.PI / 6)));

            PointF[] arrowHead = new PointF[] { arrowTip, leftWing, rightWing };
            g.FillPolygon(Brushes.Black, arrowHead);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            _isDragging = false;
            _draggedNode = null;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDragging && _draggedNode != null)
            {
                int dx = e.X - _dragStartPoint.X;
                int dy = e.Y - _dragStartPoint.Y;

                if (dx != 0 || dy != 0)
                {
                    _draggedNode.Position = new Point(_draggedNode.Position.X + dx, _draggedNode.Position.Y + dy);
                    _dragStartPoint = e.Location;
                    this.Invalidate(); // در نظر داشته باشید که محدوده مشخصی را دوباره رسم کنید
                }
            }
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            _draggedNode = GetNodeAtPosition(e.Location);
            if (_draggedNode != null)
            {
                _isDragging = true;
                _dragStartPoint = e.Location;
            }
        }
        private Node GetNodeAtPosition(Point location)
        {
            foreach (var node in graph.Nodes)
            {
                if (Math.Pow(location.X - node.Position.X, 2) + Math.Pow(location.Y - node.Position.Y, 2) <= Math.Pow(20, 2))
                {
                    return node;
                }
            }
            return null;
        }

        private void btnAddEdge_Click(object sender, EventArgs e)
        {
            addEdge addNode = new addEdge(this, null);
            addNode.ShowDialog();
        }

        private void btnAddTmp_Click(object sender, EventArgs e)
        {
            addTmp();
        }

        private void btnDijkstra_Click(object sender, EventArgs e)
        {
            DijkstraForm dijkstra = new DijkstraForm();
            dijkstra.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
        }
    }
}
