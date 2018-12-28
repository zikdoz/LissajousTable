using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using LissajousTable.app;

namespace LissajousTable.ui
{
	public partial class FormMain: Form
	{
		private const int _ROWS = 5
			, _COLUMNS = 5
			, _WIDTH = 100
			, _DOT_WIDTH = 10
			, _DOT_HALF_WIDTH = _DOT_WIDTH / 2;

		private const double _TWO_PI = 2.0 * Math.PI
			, _HALF_PI = 0.5 * Math.PI;

		private const float _STEP = 0.02f
			, _DIAMETER = 0.8f * _WIDTH
			, _RADIUS = _DIAMETER / 2f;

		private Point _span = new Point( ( _COLUMNS + 1 ) * _WIDTH, ( _ROWS + 1 ) * _WIDTH );
		private PointF _speed = new PointF( 2f, 2f );

		private LCurve[ , ] _curves;

		private readonly Pen _white_pen = new Pen( Color.White )
			, _grey_pen = new Pen( Color.DimGray, 3f );

		private float _angle = 0f;

		public FormMain()
		{
			InitializeComponent();

			Shown += ( sender, args ) => init();
			Paint += ( sender, args ) =>
			{
				Application.DoEvents();

				draw( args.Graphics );

				Invalidate();
			};
		}

		private void init()
		{
			initUiActions();

			_curves = new LCurve[ _ROWS, _COLUMNS ];

			for ( var i = 0; i < _ROWS; ++i )
			{
				for ( var j = 0; j < _COLUMNS; ++j )
				{
					_curves[ i, j ] = new LCurve();
				}
			}
		}

		private void initUiActions()
		{
			_speed.X = ( float ) nud_speed_x.Value;
			_speed.Y = ( float ) nud_speed_y.Value;

			nud_speed_x.ValueChanged += ( sender, args ) => _speed.X = ( float ) nud_speed_x.Value;
			nud_speed_y.ValueChanged += ( sender, args ) => _speed.Y = ( float ) nud_speed_y.Value;
		}

		private void draw( Graphics graphics )
		{
			graphics.SmoothingMode = SmoothingMode.AntiAlias;

			// TODO: form a function to draw things
			for ( var i = 0; i < _ROWS; ++i )
			{
				var cy = _WIDTH * ( i + 1 ) + _RADIUS;

				graphics.DrawEllipse(
					_white_pen
					, 0
					, cy - _RADIUS
					, _DIAMETER
					, _DIAMETER );

				float x = _RADIUS * ( float ) Math.Cos( _angle * ( i + _speed.Y ) - _HALF_PI )
					, y = _RADIUS * ( float ) Math.Sin( _angle * ( i + _speed.Y ) - _HALF_PI );

				graphics.FillEllipse(
					Brushes.White
					, _RADIUS + x - _DOT_HALF_WIDTH
					, cy + y - _DOT_HALF_WIDTH
					, _DOT_WIDTH
					, _DOT_WIDTH );

				graphics.DrawLine(
					_grey_pen
					, 0f
					, cy + y
					, _span.X
					, cy + y );

				for ( var j = 0; j < _COLUMNS; ++j )
				{
					_curves[ i, j ].setCurrentY( cy + y );
				}
			}

			for ( var j = 0; j < _COLUMNS; ++j )
			{
				var cx = _WIDTH * ( j + 1 ) + _RADIUS;

				graphics.DrawEllipse(
					_white_pen
					, cx - _RADIUS
					, 0
					, _DIAMETER
					, _DIAMETER );

				float x = _RADIUS * ( float ) Math.Cos( _angle * ( j + _speed.X ) - _HALF_PI )
					, y = _RADIUS * ( float ) Math.Sin( _angle * ( j + _speed.X ) - _HALF_PI );

				graphics.FillEllipse(
					Brushes.White
					, cx + x - _DOT_HALF_WIDTH
					, _RADIUS + y - _DOT_HALF_WIDTH
					, _DOT_WIDTH
					, _DOT_WIDTH );

				graphics.DrawLine(
					_grey_pen
					, cx + x
					, 0f
					, cx + x
					, _span.Y );

				for ( var i = 0; i < _ROWS; ++i )
				{
					_curves[ i, j ].setCurrentX( cx + x );
				}
			}

			foreach ( var curve in _curves )
			{
				curve.addPoint();
				curve.draw( graphics );
			}

			_angle += _STEP;

			if ( _angle >= _TWO_PI )
			{
				foreach ( var curve in _curves )
				{
					curve.reset();
				}

				_angle = 0f;
			}
		}
	}
}