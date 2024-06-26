using DataAccess.Concrete;
using MediatR;
using NuGet.Protocol.Plugins;
using TraversalCoreProject.CQRS.Commands.GuideCommands;

namespace TraversalCoreProject.CQRS.Handlers.GuideHandlers
{
    public class RemoveGuideCommandHandler : IRequestHandler<RemoveGuideCommand>
    {
        private readonly Context _context;

        public RemoveGuideCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(RemoveGuideCommand request, CancellationToken cancellationToken)
        {
            var value = _context.Guides.Find(request.Id);
            _context.Guides.Remove(value);
            _context.SaveChanges();
            return Unit.Value;
        }
    }
}
