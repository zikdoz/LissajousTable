using System.Collections.Generic;
using System.Drawing;

namespace LissajousTable.app
{
	internal class LCurve
	{
		private const int _DOT_SIZE = 8
			, _DOT_HALF_SIZE = 4;

		private readonly List< PointF > _path;
		private PointF _current;

		public LCurve()
		{
			_path = new List< PointF >();
			_current = PointF.Empty;
		}

		public void setCurrentX( float x ) { _current.X = x; }

		public void setCurrentY( float y ) { _current.Y = y; }

		public void addPoint() { _path.Add( _current ); }

		public void reset() { _path.Clear(); }

		public void draw( Graphics gr )
		{
			var path_end = _path.Count;

			for ( var i = 1; i < path_end; ++i )
			{
				gr.DrawLine(
					Pens.White
					, _path[ i - 1 ].X
					, _path[ i - 1 ].Y
					, _path[ i ].X
					, _path[ i ].Y 
					);
			}

			gr.FillEllipse(
				Brushes.White
				, _current.X - _DOT_HALF_SIZE
				, _current.Y - _DOT_HALF_SIZE
				, _DOT_SIZE
				, _DOT_SIZE );

			_current = PointF.Empty;
		}
	}
}