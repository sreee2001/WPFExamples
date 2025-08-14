using BasicControls.Topics;
using Feature.Infrastructure.Core;
using Feature.Infrastructure.Interfaces;
using Infrastructure.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;

namespace BasicControls.Label
{
    [Export(typeof(IIntroductionViewModel))]
    [ExportMetadata(MetaDataKeys.Title, AddonMetadataKeys.LabelControlTitle)]
    internal class LabelIntroductionViewModel : PropertyChangedBase, IIntroductionViewModel
    {
        public string Title => AddonMetadataKeys.LabelControlTitle;

        [ImportMany]
        public IEnumerable<Lazy<IDemonstrationViewModel, IHaveTitle>> AllDemonstrationViewModels { get; set; }

        private IDemonstrationViewModel _demonstrationViewModel;
        public IDemonstrationViewModel DemonstrationViewModel
        {
            get
            {
                if (_demonstrationViewModel == null)
                {
                    var viewModel = AllDemonstrationViewModels
                        .FirstOrDefault(vm => vm.Metadata.Title == Title)?.Value;
                    if (viewModel == null)
                    {
                        throw new InvalidOperationException($"No demonstration view model found for {Title}");
                    }
                    _demonstrationViewModel = viewModel;
                }
                return _demonstrationViewModel;
            }
        }
    }
}
