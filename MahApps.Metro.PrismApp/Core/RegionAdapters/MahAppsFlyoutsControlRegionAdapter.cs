using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using MahApps.Metro.Controls;
using Prism.Regions;

namespace MahApps.Metro.PrismApp.Core.RegionAdapters
{
    public class MahAppsFlyoutsControlRegionAdapter : RegionAdapterBase<FlyoutsControl>
    {
        public ObservableCollection<Flyout> Records { get; set; } = new ObservableCollection<Flyout>();

        public MahAppsFlyoutsControlRegionAdapter(IRegionBehaviorFactory regionBehaviorFactory) : base(regionBehaviorFactory)
        {
        }

        protected override void Adapt(IRegion region, FlyoutsControl regionTarget)
        {
            if (region == null)
            {
                throw new ArgumentNullException(nameof(region));
            }
            if (regionTarget == null)
            {
                throw new ArgumentNullException(nameof(regionTarget));
            }

            region.Views.CollectionChanged += (sender, args) =>
            {
                if (args.Action == NotifyCollectionChangedAction.Add)
                {
                    foreach (var view in args.NewItems)
                    {
                        AddViewToRegion(view, regionTarget);
                    }
                }
                else if (args.Action == NotifyCollectionChangedAction.Remove)
                {
                    foreach (var view in args.OldItems)
                    {
                        RemoveViewFromRegion(view, regionTarget);
                    }
                }
            };
        }

        protected override IRegion CreateRegion()
        {
            return new SingleActiveRegion();
        }

        private void AddViewToRegion(object view, FlyoutsControl regionTarget)
        {
            if (view is Flyout flyout)
            {
                if (regionTarget.ItemsSource == null)
                {
                    regionTarget.ItemsSource = Records;
                }

                Records.Add(flyout);
            }
        }

        private void RemoveViewFromRegion(object view, FlyoutsControl regionTarget)
        {
            if (view is Flyout flyout)
            {
                if (regionTarget.ItemsSource == null)
                {
                    regionTarget.ItemsSource = Records;
                    
                    // There should be nothing to remove after ItemSource has been set.
                    return;
                }

                Records.Add(flyout);
            }
        }
    }
}

