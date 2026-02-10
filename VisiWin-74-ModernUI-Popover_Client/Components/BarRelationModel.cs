using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HMI.Components
{
    /// <summary>
    /// Model class for managing bar relation data with four string variables.
    /// Implements <see cref="INotifyPropertyChanged"/> to support data binding in WPF applications.
    /// Provides property change notification for all public properties.
    /// </summary>
    public class BarRelationModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Backing field for <see cref="Var1"/>.
        /// </summary>
        private string var1;

        /// <summary>
        /// Backing field for <see cref="Var2"/>.
        /// </summary>
        private string var2;

        /// <summary>
        /// Backing field for <see cref="Var3"/>.
        /// </summary>
        private string var3;

        /// <summary>
        /// Backing field for <see cref="Var4"/>.
        /// </summary>
        private string var4;

        /// <summary>
        /// Gets or sets the first variable value.
        /// Raises <see cref="PropertyChanged"/> event when the value changes.
        /// </summary>
        public string Var1
        {
            get => this.var1;
            set
            {
                if (this.var1 != value)
                {
                    this.var1 = value;
                    this.OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Gets or sets the second variable value.
        /// Raises <see cref="PropertyChanged"/> event when the value changes.
        /// </summary>
        public string Var2
        {
            get => this.var2;
            set
            {
                if (this.var2 != value)
                {
                    this.var2 = value;
                    this.OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Gets or sets the third variable value.
        /// Raises <see cref="PropertyChanged"/> event when the value changes.
        /// </summary>
        public string Var3
        {
            get => this.var3;
            set
            {
                if (this.var3 != value)
                {
                    this.var3 = value;
                    this.OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Gets or sets the fourth variable value.
        /// Raises <see cref="PropertyChanged"/> event when the value changes.
        /// </summary>
        public string Var4
        {
            get => this.var4;
            set
            {
                if (this.var4 != value)
                {
                    this.var4 = value;
                    this.OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises the <see cref="PropertyChanged"/> event.
        /// </summary>
        /// <param name="propertyName">The name of the property that changed. Automatically filled by CallerMemberName attribute.</param>
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
