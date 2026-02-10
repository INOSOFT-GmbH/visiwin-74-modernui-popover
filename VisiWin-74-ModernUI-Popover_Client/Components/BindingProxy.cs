using System.Windows;

namespace HMI.Components
{
    /// <summary>
    /// Proxy class to enable data binding in scenarios where the visual tree is disconnected.
    /// Inherits from <see cref="Freezable"/> to participate in the WPF property system and allow
    /// binding to data contexts that are not directly accessible in the visual tree.
    /// Commonly used in DataGrid columns, ContextMenus, and other scenarios where the DataContext is not inherited.
    /// </summary>
    public class BindingProxy : Freezable
    {
        /// <summary>
        /// Gets or sets the data object to be proxied.
        /// This property can be bound to any data context and makes it accessible in disconnected visual trees.
        /// </summary>
        public object Data
        {
            get => this.GetValue(DataProperty);
            set => SetValue(DataProperty, value);
        }

        /// <summary>
        /// Dependency property for <see cref="Data"/>.
        /// </summary>
        public static readonly DependencyProperty DataProperty = DependencyProperty.Register(nameof(Data), typeof(object), typeof(BindingProxy), new UIPropertyMetadata(null));

        /// <summary>
        /// Creates a new instance of the <see cref="BindingProxy"/> class.
        /// Required override from <see cref="Freezable"/> base class.
        /// </summary>
        /// <returns>A new instance of <see cref="BindingProxy"/>.</returns>
        protected override Freezable CreateInstanceCore()
        {
            return new BindingProxy();
        }
    }
}