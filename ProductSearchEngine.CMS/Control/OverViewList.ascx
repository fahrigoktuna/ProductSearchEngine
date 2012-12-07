<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="OverViewList.ascx.cs" Inherits="ProductSearchEngine.CMS.Control.OverViewList" %>

	
			<div class="grid_4">
				<div class="block-border">
					<div class="block-header">
						<h1>Overview-List</h1><span></span>
					</div>
					<div class="block-content">
						<div class="alert info no-margin top">You have 6 tickets.</div>
						<ul class="overview-list">
							<li><a href="javascript:void(0);"><span><%=TotalVisit %></span> Total Visits</a></li>
							<li><a href="javascript:void(0);"><span><%=TodayVisit %></span> Today Visits</a></li>
							<li><a href="javascript:void(0);"><span><%=TotalComments %></span> Total Comments</a></li>
							<li><a href="javascript:void(0);"><span><%=TotalProducts %></span> Total Products</a></li>
                            <li><a href="javascript:void(0);"><span style="width:150px"><%=MostVisitedIp %></span> Most Visited IP</a></li>
                            <li><a href="javascript:void(0);"><span style="width:300px"><%=MostVisitedBrowser %></span> Most Visited Browser</a></li>
						</ul>
					</div>
				</div>
			</div>
			