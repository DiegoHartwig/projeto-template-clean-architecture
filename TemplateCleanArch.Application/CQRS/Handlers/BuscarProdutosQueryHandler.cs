﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using TemplateCleanArch.Application.CQRS.Queries;
using TemplateCleanArch.Domain.Entities;
using TemplateCleanArch.Domain.Interfaces;

namespace TemplateCleanArch.Application.CQRS.Handlers
{
	public class BuscarProdutosQueryHandler : IRequestHandler<BuscarProdutosQuery, IEnumerable<Produto>>
	{
		private readonly IProdutoRepository _produtoRepository;

		public BuscarProdutosQueryHandler(IProdutoRepository produtoRepository)
		{
			_produtoRepository = produtoRepository ??
				throw new ArgumentNullException(nameof(produtoRepository));
		}

		public async Task<IEnumerable<Produto>> Handle(BuscarProdutosQuery request, CancellationToken cancellationToken)
		{
			return await _produtoRepository.BuscarProdutosAsync();
		}
	}
}
