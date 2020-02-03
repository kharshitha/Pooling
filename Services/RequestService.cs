using System;
using System.Collections.Generic;
using System.Text;
using Models;
using System.Linq;
using Interface;

namespace Services
{
    public class RequestService:IRequestService
    {
        public List<Request> DisplayRequest(string OffererId,List<Request> requests)
        {
            return requests.Where(r => r.OffererId == OffererId).ToList();
        }
        public void AddRequest(List<Request> requests,Request request)
        {
            requests.Add(request);
        }
        public void AddRequestId(User user,string requestId)
        {
            user.RequestIds.Add(requestId);
        }
        public void AddConformationId(User user,string requestId)
        {
            user.ConfirmationIds.Add(requestId);
        }
    }
}
