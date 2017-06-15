Imports SkiaSharp
Imports SkiaSharp.Views.Forms
Imports Xamarin.Forms

Public Class MainPage
	Inherits ContentPage

	Private WithEvents canvasView As SKCanvasView

	Public Sub New()
		canvasView = New SKCanvasView

		Dim mainGrid = New Grid
		mainGrid.Children.Add(canvasView)

		Content = mainGrid
		Title = "SkiaSharp"
	End Sub

	Private Sub OnPainting(ByVal sender As Object, ByVal e As SKPaintSurfaceEventArgs) Handles canvasView.PaintSurface
		' CLEARING THE SURFACE

		' we get the current surface from the event args
		Dim surface = e.Surface
		' then we get the canvas that we can draw on
		Dim canvas = surface.Canvas
		' clear the canvas / view
		canvas.Clear(SKColors.White)


		' DRAWING SHAPES

		' create the paint for the filled circle
		Dim circleFill = New SKPaint With {
			.IsAntialias = True,
			.Style = SKPaintStyle.Fill,
			.Color = SKColors.Blue
		}
		' draw the circle fill
		canvas.DrawCircle(100, 100, 40, circleFill)

		' create the paint for the circle border
		Dim circleBorder = New SKPaint With {
			.IsAntialias = True,
			.Style = SKPaintStyle.Stroke,
			.Color = SKColors.Red,
			.StrokeWidth = 5
		}
		' draw the circle border
		canvas.DrawCircle(100, 100, 40, circleBorder)


		' DRAWING PATHS

		' create the paint for the path
		Dim pathStroke = New SKPaint With {
			.IsAntialias = True,
			.Style = SKPaintStyle.Stroke,
			.Color = SKColors.Green,
			.StrokeWidth = 5
		}

		' create a path
		Dim path = New SKPath
		path.MoveTo(160, 60)
		path.LineTo(240, 140)
		path.MoveTo(240, 60)
		path.LineTo(160, 140)

		' draw the path
		canvas.DrawPath(path, pathStroke)


		' DRAWING TEXT

		' create the paint for the text
		Dim textPaint = New SKPaint With {
			.IsAntialias = True,
			.Style = SKPaintStyle.Fill,
			.Color = SKColors.Orange,
			.TextSize = 80
		}
		' draw the text (from the baseline)
		canvas.DrawText("SkiaSharp", 60, 160 + 80, textPaint)
	End Sub

End Class
