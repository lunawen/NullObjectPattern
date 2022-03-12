using NullObjectPattern.Entities;
using NullObjectPattern.Services;
using NullObjectPattern.View;

LearnerService learnerService = new LearnerService();
ILearner learner = learnerService.GetCurrentLearner();

LearnerView view = new LearnerView(learner);
view.RenderView();