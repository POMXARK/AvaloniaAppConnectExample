using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Media;
using Avalonia.ReactiveUI;
using AvaloniaAppConnectExample.ViewModels;
using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Reactive.Disposables;

namespace AvaloniaAppConnectExample.Views
{
    public partial class CanvasView : ReactiveUserControl<CanvasViewModel>
    {
        public TranslateTransform TranslateTransformNode;
        public CanvasView()
        {
            InitializeComponent();
            TranslateTransformNode = RenderTransform as TranslateTransform;
            SetupEvents();
        }

        private Point oldPosition;
        protected void SetupEvents()
        {
            BorderNode.Events().PointerPressed.Subscribe(OnEventBorderPointerPressed);
            BorderNode.Events().PointerReleased.Subscribe(OnEventBorderPointerReleased);
        }

        private void OnEventBorderPointerPressed(PointerPressedEventArgs e)
        {
            Debug.WriteLine("OnEventBorderPointerPressed");
        }

        private void OnEventBorderPointerReleased(PointerReleasedEventArgs e)
        {
            Debug.WriteLine("OnEventBorderPointerReleased");
        }
    }
}
