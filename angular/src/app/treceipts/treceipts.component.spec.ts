import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TreceiptsComponent } from './treceipts.component';

describe('TreceiptsComponent', () => {
  let component: TreceiptsComponent;
  let fixture: ComponentFixture<TreceiptsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TreceiptsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TreceiptsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
