using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace Interface
{
    public interface IRequestService
    {
        public List<Request> DisplayRequest(string OffererId, List<Request> requests);
        public void AddRequest(List<Request> requests, Request request);
        public void AddRequestId(User user, string requestId);
        public void AddConformationId(User user, string requestId);
    }
}
